using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementTextFieldEntityData))]
	public class PamUIElementTextFieldEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementTextFieldEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementTextFieldEntityData Data => data as FrostySdk.Ebx.PamUIElementTextFieldEntityData;
		public override string DisplayName => "PamUIElementTextField";

		public PamUIElementTextFieldEntity(FrostySdk.Ebx.PamUIElementTextFieldEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

