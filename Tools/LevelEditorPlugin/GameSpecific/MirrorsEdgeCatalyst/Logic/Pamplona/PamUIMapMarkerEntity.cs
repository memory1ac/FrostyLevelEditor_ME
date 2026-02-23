using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIMapMarkerEntityData))]
	public class PamUIMapMarkerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUIMapMarkerEntityData>
	{
		public new FrostySdk.Ebx.PamUIMapMarkerEntityData Data => data as FrostySdk.Ebx.PamUIMapMarkerEntityData;
		public override string DisplayName => "PamUIMapMarker";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUIMapMarkerEntity(FrostySdk.Ebx.PamUIMapMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

