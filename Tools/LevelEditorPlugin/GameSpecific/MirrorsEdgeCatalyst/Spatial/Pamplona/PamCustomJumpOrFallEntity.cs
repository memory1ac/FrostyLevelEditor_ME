using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCustomJumpOrFallEntityData))]
	public class PamCustomJumpOrFallEntity : PamFindableMovementVolumeEntity, IEntityData<FrostySdk.Ebx.PamCustomJumpOrFallEntityData>
	{
		public new FrostySdk.Ebx.PamCustomJumpOrFallEntityData Data => data as FrostySdk.Ebx.PamCustomJumpOrFallEntityData;

		public PamCustomJumpOrFallEntity(FrostySdk.Ebx.PamCustomJumpOrFallEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

