
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VOSoundEntityTrackAssetLayerData))]
	public class VOSoundEntityTrackAssetLayer : SoundEntityTrackLayer, IEntityData<FrostySdk.Ebx.VOSoundEntityTrackAssetLayerData>
	{
		public new FrostySdk.Ebx.VOSoundEntityTrackAssetLayerData Data => data as FrostySdk.Ebx.VOSoundEntityTrackAssetLayerData;
		public override string DisplayName => "VOSoundEntityTrackAssetLayer";

		public VOSoundEntityTrackAssetLayer(FrostySdk.Ebx.VOSoundEntityTrackAssetLayerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

