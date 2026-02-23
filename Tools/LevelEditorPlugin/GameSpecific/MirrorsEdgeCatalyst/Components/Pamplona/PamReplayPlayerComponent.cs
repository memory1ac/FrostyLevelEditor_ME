
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamReplayPlayerComponentData))]
	public class PamReplayPlayerComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamReplayPlayerComponentData>
	{
		public new FrostySdk.Ebx.PamReplayPlayerComponentData Data => data as FrostySdk.Ebx.PamReplayPlayerComponentData;
		public override string DisplayName => "PamReplayPlayerComponent";

		public PamReplayPlayerComponent(FrostySdk.Ebx.PamReplayPlayerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

