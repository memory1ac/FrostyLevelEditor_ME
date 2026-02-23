using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamWidgetDataProviderEntityBaseData))]
	public class PamWidgetDataProviderEntityBase : LogicEntity, IEntityData<FrostySdk.Ebx.PamWidgetDataProviderEntityBaseData>
	{
		public new FrostySdk.Ebx.PamWidgetDataProviderEntityBaseData Data => data as FrostySdk.Ebx.PamWidgetDataProviderEntityBaseData;
		public override string DisplayName => "PamWidgetDataProviderEntityBase";

		public PamWidgetDataProviderEntityBase(FrostySdk.Ebx.PamWidgetDataProviderEntityBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

