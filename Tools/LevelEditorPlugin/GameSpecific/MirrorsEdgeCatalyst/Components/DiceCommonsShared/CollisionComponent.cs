
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CollisionComponentData))]
	public class CollisionComponent : GameComponent, IEntityData<FrostySdk.Ebx.CollisionComponentData>
	{
		public new FrostySdk.Ebx.CollisionComponentData Data => data as FrostySdk.Ebx.CollisionComponentData;
		public override string DisplayName => "CollisionComponent";

		public CollisionComponent(FrostySdk.Ebx.CollisionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

