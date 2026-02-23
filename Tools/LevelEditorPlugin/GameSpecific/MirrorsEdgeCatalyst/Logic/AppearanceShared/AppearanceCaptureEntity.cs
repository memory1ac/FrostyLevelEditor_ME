using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AppearanceCaptureEntityData))]
	public class AppearanceCaptureEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AppearanceCaptureEntityData>
	{
		public new FrostySdk.Ebx.AppearanceCaptureEntityData Data => data as FrostySdk.Ebx.AppearanceCaptureEntityData;
		public override string DisplayName => "AppearanceCapture";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AppearanceCaptureEntity(FrostySdk.Ebx.AppearanceCaptureEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

