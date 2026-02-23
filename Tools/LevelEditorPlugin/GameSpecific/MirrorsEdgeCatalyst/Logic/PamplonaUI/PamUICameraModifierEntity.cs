using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUICameraModifierEntityData))]
	public class PamUICameraModifierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUICameraModifierEntityData>
	{
		public new FrostySdk.Ebx.PamUICameraModifierEntityData Data => data as FrostySdk.Ebx.PamUICameraModifierEntityData;
		public override string DisplayName => "PamUICameraModifier";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUICameraModifierEntity(FrostySdk.Ebx.PamUICameraModifierEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

