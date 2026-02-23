using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamSettingsReaderEntityData))]
	public class PamSettingsReaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamSettingsReaderEntityData>
	{
		public new FrostySdk.Ebx.PamSettingsReaderEntityData Data => data as FrostySdk.Ebx.PamSettingsReaderEntityData;
		public override string DisplayName => "PamSettingsReader";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamSettingsReaderEntity(FrostySdk.Ebx.PamSettingsReaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

