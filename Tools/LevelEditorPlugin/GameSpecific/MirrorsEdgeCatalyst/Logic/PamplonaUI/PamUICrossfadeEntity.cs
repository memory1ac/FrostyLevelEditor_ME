using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUICrossfadeEntityData))]
	public class PamUICrossfadeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamUICrossfadeEntityData>
	{
		public new FrostySdk.Ebx.PamUICrossfadeEntityData Data => data as FrostySdk.Ebx.PamUICrossfadeEntityData;
		public override string DisplayName => "PamUICrossfade";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamUICrossfadeEntity(FrostySdk.Ebx.PamUICrossfadeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

