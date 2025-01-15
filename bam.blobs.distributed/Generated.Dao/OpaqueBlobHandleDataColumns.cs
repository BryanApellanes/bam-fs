using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bam;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobHandleDataColumns: QueryFilter<OpaqueBlobHandleDataColumns>, IFilterToken
    {
        public OpaqueBlobHandleDataColumns() { }
        public OpaqueBlobHandleDataColumns(string columnName, bool isForeignKey = false)
            : base(columnName)
        { 
            _isForeignKey = isForeignKey;
        }
        
        public bool IsKey()
        {
            return (bool)ColumnName?.Equals(KeyColumn.ColumnName);
        }

        private bool? _isForeignKey;
        public bool IsForeignKey
        {
            get
            {
                if (_isForeignKey == null)
                {
                    PropertyInfo prop = DaoType
                        .GetProperties()
                        .FirstOrDefault(pi => ((MemberInfo) pi)
                            .HasCustomAttributeOfType<ForeignKeyAttribute>(out ForeignKeyAttribute foreignKeyAttribute)
                                && foreignKeyAttribute.Name.Equals(ColumnName));
                        _isForeignKey = prop != null;
                }

                return _isForeignKey.Value;
            }
            set => _isForeignKey = value;
        }
        
		public OpaqueBlobHandleDataColumns KeyColumn => new OpaqueBlobHandleDataColumns("Id");

        public OpaqueBlobHandleDataColumns Id => new OpaqueBlobHandleDataColumns("Id");
        public OpaqueBlobHandleDataColumns Uuid => new OpaqueBlobHandleDataColumns("Uuid");
        public OpaqueBlobHandleDataColumns Cuid => new OpaqueBlobHandleDataColumns("Cuid");
        public OpaqueBlobHandleDataColumns AuthorHandleHmac => new OpaqueBlobHandleDataColumns("AuthorHandleHmac");
        public OpaqueBlobHandleDataColumns BlobHashHmac => new OpaqueBlobHandleDataColumns("BlobHashHmac");
        public OpaqueBlobHandleDataColumns Created => new OpaqueBlobHandleDataColumns("Created");


		public Type DaoType => typeof(OpaqueBlobHandleData);

		public string Operator { get; set; }

        public override string ToString()
        {
            return base.ColumnName;
        }
	}
}