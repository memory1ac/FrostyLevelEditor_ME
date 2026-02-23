using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIWidgetBlueprintSelectorEntityData))]
	public class PamClientUIWidgetBlueprintSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientUIWidgetBlueprintSelectorEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIWidgetBlueprintSelectorEntityData Data => data as FrostySdk.Ebx.PamClientUIWidgetBlueprintSelectorEntityData;
		public override string DisplayName => "PamClientUIWidgetBlueprintSelector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIWidgetBlueprintSelectorEntity(FrostySdk.Ebx.PamClientUIWidgetBlueprintSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

