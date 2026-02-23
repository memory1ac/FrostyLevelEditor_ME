using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientUIFriendsWidgetDataProviderEntityData))]
	public class PamClientUIFriendsWidgetDataProviderEntity : PamClientUIListWidgetDataProviderEntity, IEntityData<FrostySdk.Ebx.PamClientUIFriendsWidgetDataProviderEntityData>
	{
		public new FrostySdk.Ebx.PamClientUIFriendsWidgetDataProviderEntityData Data => data as FrostySdk.Ebx.PamClientUIFriendsWidgetDataProviderEntityData;
		public override string DisplayName => "PamClientUIFriendsWidgetDataProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamClientUIFriendsWidgetDataProviderEntity(FrostySdk.Ebx.PamClientUIFriendsWidgetDataProviderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

