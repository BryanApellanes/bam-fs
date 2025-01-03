using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Bam;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class BlobChunkAssociationDataColumns: QueryFilter<BlobChunkAssociationDataColumns>, IFilterToken
    {
        public BlobChunkAssociationDataColumns() { }
        public BlobChunkAssociationDataColumns(string columnName, bool isForeignKey = false)
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
        
		public BlobChunkAssociationDataColumns KeyColumn => new BlobChunkAssociationDataColumns("Id");

        public BlobChunkAssociationDataColumns Id => new BlobChunkAssociationDataColumns("Id");
        public BlobChunkAssociationDataColumns Uuid => new BlobChunkAssociationDataColumns("Uuid");
        public BlobChunkAssociationDataColumns Cuid => new BlobChunkAssociationDataColumns("Cuid");
        public BlobChunkAssociationDataColumns BlobHash => new BlobChunkAssociationDataColumns("BlobHash");
        public BlobChunkAssociationDataColumns ChunkHash => new BlobChunkAssociationDataColumns("ChunkHash");
        public BlobChunkAssociationDataColumns ChunkIndex => new BlobChunkAssociationDataColumns("ChunkIndex");
        public BlobChunkAssociationDataColumns StreamIndex => new BlobChunkAssociationDataColumns("StreamIndex");
        public BlobChunkAssociationDataColumns Created => new BlobChunkAssociationDataColumns("Created");


		public Type DaoType => typeof(BlobChunkAssociationData);

		public string Operator { get; set; }

        public override string ToString()
        {
            return base.ColumnName;
        }
	}
}