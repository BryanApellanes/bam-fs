using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bam;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class BlobDescriptorDataColumns: QueryFilter<BlobDescriptorDataColumns>, IFilterToken
    {
        public BlobDescriptorDataColumns() { }
        public BlobDescriptorDataColumns(string columnName, bool isForeignKey = false)
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
        
		public BlobDescriptorDataColumns KeyColumn => new BlobDescriptorDataColumns("Id");

        public BlobDescriptorDataColumns Id => new BlobDescriptorDataColumns("Id");
        public BlobDescriptorDataColumns Uuid => new BlobDescriptorDataColumns("Uuid");
        public BlobDescriptorDataColumns Cuid => new BlobDescriptorDataColumns("Cuid");
        public BlobDescriptorDataColumns BlobHash => new BlobDescriptorDataColumns("BlobHash");
        public BlobDescriptorDataColumns Title => new BlobDescriptorDataColumns("Title");
        public BlobDescriptorDataColumns Description => new BlobDescriptorDataColumns("Description");
        public BlobDescriptorDataColumns Length => new BlobDescriptorDataColumns("Length");
        public BlobDescriptorDataColumns ChunkCount => new BlobDescriptorDataColumns("ChunkCount");
        public BlobDescriptorDataColumns ChunkLength => new BlobDescriptorDataColumns("ChunkLength");
        public BlobDescriptorDataColumns Created => new BlobDescriptorDataColumns("Created");


		public Type DaoType => typeof(BlobDescriptorData);

		public string Operator { get; set; }

        public override string ToString()
        {
            return base.ColumnName;
        }
	}
}