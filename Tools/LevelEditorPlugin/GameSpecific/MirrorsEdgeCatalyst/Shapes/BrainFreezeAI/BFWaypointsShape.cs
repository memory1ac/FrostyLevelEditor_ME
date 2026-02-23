using Frosty.Core.Viewport;
using SharpDX;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFWaypointsShapeData))]
	public class BFWaypointsShape : WaypointsShape, IEntityData<FrostySdk.Ebx.BFWaypointsShapeData>
	{
		public new FrostySdk.Ebx.BFWaypointsShapeData Data => data as FrostySdk.Ebx.BFWaypointsShapeData;
		public override string DisplayName => "BFWaypointsShape";

		public BFWaypointsShape(FrostySdk.Ebx.BFWaypointsShapeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

