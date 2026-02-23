using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamVoiceOverLocatorEntityData))]
	public class PamVoiceOverLocatorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.PamVoiceOverLocatorEntityData>
	{
		public new FrostySdk.Ebx.PamVoiceOverLocatorEntityData Data => data as FrostySdk.Ebx.PamVoiceOverLocatorEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PamVoiceOverLocatorEntity(FrostySdk.Ebx.PamVoiceOverLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

