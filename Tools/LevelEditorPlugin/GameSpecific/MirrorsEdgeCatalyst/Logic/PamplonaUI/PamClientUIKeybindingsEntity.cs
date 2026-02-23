using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIKeybindingsEntityData))]
	public class PamClientUIKeybindingsEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIKeybindingsEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIKeybindingsEntityData Data => data as FrostySdk.Ebx.PamClientUIKeybindingsEntityData;
		public override string DisplayName => "PamClientUIKeybindings";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIKeybindingsEntity(FrostySdk.Ebx.PamClientUIKeybindingsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

