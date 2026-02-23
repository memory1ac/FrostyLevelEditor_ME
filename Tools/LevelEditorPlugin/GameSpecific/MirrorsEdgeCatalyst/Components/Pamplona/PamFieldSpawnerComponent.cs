
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamFieldSpawnerComponentData))]
	public class PamFieldSpawnerComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamFieldSpawnerComponentData>
	{
		public new FrostySdk.Ebx.PamFieldSpawnerComponentData Data => data as FrostySdk.Ebx.PamFieldSpawnerComponentData;
		public override string DisplayName => "PamFieldSpawnerComponent";

		public PamFieldSpawnerComponent(FrostySdk.Ebx.PamFieldSpawnerComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

