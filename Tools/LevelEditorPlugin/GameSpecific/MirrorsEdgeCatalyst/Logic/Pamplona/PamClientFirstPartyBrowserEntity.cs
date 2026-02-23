using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamClientFirstPartyBrowserEntityData))]
	public class PamClientFirstPartyBrowserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PamClientFirstPartyBrowserEntityData>
	{
		public new FrostySdk.Ebx.PamClientFirstPartyBrowserEntityData Data => data as FrostySdk.Ebx.PamClientFirstPartyBrowserEntityData;
		public override string DisplayName => "PamClientFirstPartyBrowser";

		public PamClientFirstPartyBrowserEntity(FrostySdk.Ebx.PamClientFirstPartyBrowserEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

