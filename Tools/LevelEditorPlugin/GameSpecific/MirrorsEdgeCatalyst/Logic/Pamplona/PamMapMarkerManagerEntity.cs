using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamMapMarkerManagerEntityData))]
	public class PamMapMarkerManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamMapMarkerManagerEntityData>
	{
		public new FrostySdk.Ebx.PamMapMarkerManagerEntityData Data => data as FrostySdk.Ebx.PamMapMarkerManagerEntityData;
		public override string DisplayName => "PamMapMarkerManager";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamMapMarkerManagerEntity(FrostySdk.Ebx.PamMapMarkerManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

