using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamEchoCustomizationManagerEntityData))]
	public class PamEchoCustomizationManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamEchoCustomizationManagerEntityData>
	{
		public new FrostySdk.Ebx.PamEchoCustomizationManagerEntityData Data => data as FrostySdk.Ebx.PamEchoCustomizationManagerEntityData;
		public override string DisplayName => "PamEchoCustomizationManager";

		public PamEchoCustomizationManagerEntity(FrostySdk.Ebx.PamEchoCustomizationManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

