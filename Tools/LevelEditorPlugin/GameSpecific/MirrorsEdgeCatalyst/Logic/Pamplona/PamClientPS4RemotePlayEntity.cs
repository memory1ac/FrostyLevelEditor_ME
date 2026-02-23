using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientPS4RemotePlayEntityData))]
	public class PamClientPS4RemotePlayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientPS4RemotePlayEntityData>
	{
		public new FrostySdk.Ebx.PamClientPS4RemotePlayEntityData Data => data as FrostySdk.Ebx.PamClientPS4RemotePlayEntityData;
		public override string DisplayName => "PamClientPS4RemotePlay";

		public PamClientPS4RemotePlayEntity(FrostySdk.Ebx.PamClientPS4RemotePlayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

