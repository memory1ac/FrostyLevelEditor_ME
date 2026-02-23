using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSwitchPropertyLocalizedStringEntityData))]
	public class PamSwitchPropertyLocalizedStringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSwitchPropertyLocalizedStringEntityData>
	{
		public new FrostySdk.Ebx.PamSwitchPropertyLocalizedStringEntityData Data => data as FrostySdk.Ebx.PamSwitchPropertyLocalizedStringEntityData;
		public override string DisplayName => "PamSwitchPropertyLocalizedString";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSwitchPropertyLocalizedStringEntity(FrostySdk.Ebx.PamSwitchPropertyLocalizedStringEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

