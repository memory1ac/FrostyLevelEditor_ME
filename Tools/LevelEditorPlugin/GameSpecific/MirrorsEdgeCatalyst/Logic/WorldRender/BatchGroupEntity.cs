using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BatchGroupEntityData))]
	public class BatchGroupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BatchGroupEntityData>
	{
		public new FrostySdk.Ebx.BatchGroupEntityData Data => data as FrostySdk.Ebx.BatchGroupEntityData;
		public override string DisplayName => "BatchGroup";

		public BatchGroupEntity(FrostySdk.Ebx.BatchGroupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

