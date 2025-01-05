using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bam;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class OpaqueKeyValueDataColumns: QueryFilter<OpaqueKeyValueDataColumns>, IFilterToken
    {
        public OpaqueKeyValueDataColumns() { }
        public OpaqueKeyValueDataColumns(string columnName, bool isForeignKey = false)
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
        
		public OpaqueKeyValueDataColumns KeyColumn => new OpaqueKeyValueDataColumns("Id");

        public OpaqueKeyValueDataColumns Id => new OpaqueKeyValueDataColumns("Id");
        public OpaqueKeyValueDataColumns Uuid => new OpaqueKeyValueDataColumns("Uuid");
        public OpaqueKeyValueDataColumns Cuid => new OpaqueKeyValueDataColumns("Cuid");
        public OpaqueKeyValueDataColumns Key => new OpaqueKeyValueDataColumns("Key");
        public OpaqueKeyValueDataColumns Value => new OpaqueKeyValueDataColumns("Value");
        public OpaqueKeyValueDataColumns Created => new OpaqueKeyValueDataColumns("Created");


		public Type DaoType => typeof(OpaqueKeyValueData);

		public string Operator { get; set; }

        public override string ToString()
        {
            return base.ColumnName;
        }
	}
}