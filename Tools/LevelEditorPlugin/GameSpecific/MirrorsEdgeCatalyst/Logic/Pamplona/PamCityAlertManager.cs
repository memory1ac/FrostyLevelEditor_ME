using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCityAlertManagerData))]
	public class PamCityAlertManager : LogicEntity, IEntityData<FrostySdk.Ebx.PamCityAlertManagerData>
	{
		public new FrostySdk.Ebx.PamCityAlertManagerData Data => data as FrostySdk.Ebx.PamCityAlertManagerData;
		public override string DisplayName => "PamCityAlertManager";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamCityAlertManager(FrostySdk.Ebx.PamCityAlertManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

