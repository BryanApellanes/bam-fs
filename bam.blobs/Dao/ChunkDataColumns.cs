using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bam;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class ChunkDataColumns: QueryFilter<ChunkDataColumns>, IFilterToken
    {
        public ChunkDataColumns() { }
        public ChunkDataColumns(string columnName, bool isForeignKey = false)
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
        
		public ChunkDataColumns KeyColumn => new ChunkDataColumns("Id");

        public ChunkDataColumns Id => new ChunkDataColumns("Id");
        public ChunkDataColumns Uuid => new ChunkDataColumns("Uuid");
        public ChunkDataColumns Cuid => new ChunkDataColumns("Cuid");
        public ChunkDataColumns ChunkHash => new ChunkDataColumns("ChunkHash");
        public ChunkDataColumns Data => new ChunkDataColumns("Data");
        public ChunkDataColumns Created => new ChunkDataColumns("Created");


		public Type DaoType => typeof(ChunkData);

		public string Operator { get; set; }

        public override string ToString()
        {
            return base.ColumnName;
        }
	}
}