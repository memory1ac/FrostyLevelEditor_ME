using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamAnimatableCullingEntityData))]
	public class PamAnimatableCullingEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamAnimatableCullingEntityData>
	{
		public new FrostySdk.Ebx.PamAnimatableCullingEntityData Data => data as FrostySdk.Ebx.PamAnimatableCullingEntityData;
		public override string DisplayName => "PamAnimatableCulling";

		public PamAnimatableCullingEntity(FrostySdk.Ebx.PamAnimatableCullingEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

