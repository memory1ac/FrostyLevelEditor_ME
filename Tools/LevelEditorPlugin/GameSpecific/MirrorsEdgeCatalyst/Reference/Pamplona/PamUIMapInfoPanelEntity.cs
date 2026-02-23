using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapInfoPanelEntityData))]
	public class PamUIMapInfoPanelEntity : WidgetReferenceEntity, IEntityData<FrostySdk.Ebx.PamUIMapInfoPanelEntityData>
	{
		public new FrostySdk.Ebx.PamUIMapInfoPanelEntityData Data => data as FrostySdk.Ebx.PamUIMapInfoPanelEntityData;

		public PamUIMapInfoPanelEntity(FrostySdk.Ebx.PamUIMapInfoPanelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

