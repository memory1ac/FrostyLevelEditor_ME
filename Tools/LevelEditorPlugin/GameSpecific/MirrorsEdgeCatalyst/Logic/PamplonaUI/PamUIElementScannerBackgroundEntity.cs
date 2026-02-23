using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamUIElementScannerBackgroundEntityData))]
	public class PamUIElementScannerBackgroundEntity : PamUIDynamicElementEntity, IEntityData<FrostySdk.Ebx.PamUIElementScannerBackgroundEntityData>
	{
		public new FrostySdk.Ebx.PamUIElementScannerBackgroundEntityData Data => data as FrostySdk.Ebx.PamUIElementScannerBackgroundEntityData;
		public override string DisplayName => "PamUIElementScannerBackground";

		public PamUIElementScannerBackgroundEntity(FrostySdk.Ebx.PamUIElementScannerBackgroundEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

