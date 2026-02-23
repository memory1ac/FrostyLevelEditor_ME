using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementStickyMapMarkerIconsEntityData))]
	public class PamUIElementStickyMapMarkerIconsEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementStickyMapMarkerIconsEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementStickyMapMarkerIconsEntityData Data => data as FrostySdk.Ebx.PamUIElementStickyMapMarkerIconsEntityData;
		public override string DisplayName => "PamUIElementStickyMapMarkerIcons";

		public PamUIElementStickyMapMarkerIconsEntity(FrostySdk.Ebx.PamUIElementStickyMapMarkerIconsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

