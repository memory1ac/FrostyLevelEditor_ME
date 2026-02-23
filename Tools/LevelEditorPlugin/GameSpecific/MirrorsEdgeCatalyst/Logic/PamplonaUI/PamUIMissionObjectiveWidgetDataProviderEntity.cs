using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMissionObjectiveWidgetDataProviderEntityData))]
	public class PamUIMissionObjectiveWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamUIMissionObjectiveWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamUIMissionObjectiveWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamUIMissionObjectiveWidgetDataProviderEntityData;
		public override string DisplayName => "PamUIMissionObjectiveWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIMissionObjectiveWidgetDataProviderEntity(FrostySdk.Ebx.PamUIMissionObjectiveWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

