using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BatchGroupListenerEntityData))]
	public class BatchGroupListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BatchGroupListenerEntityData>
	{
		public new FrostySdk.Ebx.BatchGroupListenerEntityData Data => data as FrostySdk.Ebx.BatchGroupListenerEntityData;
		public override string DisplayName => "BatchGroupListener";

		public BatchGroupListenerEntity(FrostySdk.Ebx.BatchGroupListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

