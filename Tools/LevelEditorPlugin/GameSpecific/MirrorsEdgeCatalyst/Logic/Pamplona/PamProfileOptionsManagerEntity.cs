using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamProfileOptionsManagerEntityData))]
	public class PamProfileOptionsManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamProfileOptionsManagerEntityData>
	{
		public new FrostySdk.Ebx.PamProfileOptionsManagerEntityData Data => data as FrostySdk.Ebx.PamProfileOptionsManagerEntityData;
		public override string DisplayName => "PamProfileOptionsManager";

		public PamProfileOptionsManagerEntity(FrostySdk.Ebx.PamProfileOptionsManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

