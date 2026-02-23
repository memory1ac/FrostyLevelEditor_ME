using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamDestructionEntityData))]
	public class PamDestructionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamDestructionEntityData>
	{
		public new FrostySdk.Ebx.PamDestructionEntityData Data => data as FrostySdk.Ebx.PamDestructionEntityData;
		public override string DisplayName => "PamDestruction";

		public PamDestructionEntity(FrostySdk.Ebx.PamDestructionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

