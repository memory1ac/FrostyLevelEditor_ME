using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AirPathfindingVolumeData))]
	public class AirPathfindingVolume : OBB, IEntityData<FrostySdk.Ebx.AirPathfindingVolumeData>
	{
		public new FrostySdk.Ebx.AirPathfindingVolumeData Data => data as FrostySdk.Ebx.AirPathfindingVolumeData;
		public override string DisplayName => "AirPathfindingVolume";

		public AirPathfindingVolume(FrostySdk.Ebx.AirPathfindingVolumeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

