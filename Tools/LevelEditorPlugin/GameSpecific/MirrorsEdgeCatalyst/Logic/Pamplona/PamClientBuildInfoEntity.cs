using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientBuildInfoEntityData))]
	public class PamClientBuildInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientBuildInfoEntityData>
	{
		public new FrostySdk.Ebx.PamClientBuildInfoEntityData Data => data as FrostySdk.Ebx.PamClientBuildInfoEntityData;
		public override string DisplayName => "PamClientBuildInfo";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientBuildInfoEntity(FrostySdk.Ebx.PamClientBuildInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

