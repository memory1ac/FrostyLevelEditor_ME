using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamPrivacyPermissionEntityData))]
	public class PamPrivacyPermissionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamPrivacyPermissionEntityData>
	{
		public new FrostySdk.Ebx.PamPrivacyPermissionEntityData Data => data as FrostySdk.Ebx.PamPrivacyPermissionEntityData;
		public override string DisplayName => "PamPrivacyPermission";

		public PamPrivacyPermissionEntity(FrostySdk.Ebx.PamPrivacyPermissionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

