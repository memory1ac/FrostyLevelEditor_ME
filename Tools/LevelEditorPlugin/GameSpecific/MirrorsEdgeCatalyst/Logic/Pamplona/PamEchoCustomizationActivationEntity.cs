using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamEchoCustomizationActivationEntityData))]
	public class PamEchoCustomizationActivationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamEchoCustomizationActivationEntityData>
	{
		public new FrostySdk.Ebx.PamEchoCustomizationActivationEntityData Data => data as FrostySdk.Ebx.PamEchoCustomizationActivationEntityData;
		public override string DisplayName => "PamEchoCustomizationActivation";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamEchoCustomizationActivationEntity(FrostySdk.Ebx.PamEchoCustomizationActivationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

