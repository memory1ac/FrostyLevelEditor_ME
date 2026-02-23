using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamGetVersionOfVersionedRawFileEntityData))]
	public class PamGetVersionOfVersionedRawFileEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamGetVersionOfVersionedRawFileEntityData>
	{
		public new FrostySdk.Ebx.PamGetVersionOfVersionedRawFileEntityData Data => data as FrostySdk.Ebx.PamGetVersionOfVersionedRawFileEntityData;
		public override string DisplayName => "PamGetVersionOfVersionedRawFile";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamGetVersionOfVersionedRawFileEntity(FrostySdk.Ebx.PamGetVersionOfVersionedRawFileEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

