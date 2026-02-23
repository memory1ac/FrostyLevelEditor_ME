
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CapsuleCollisionComponentData))]
	public class CapsuleCollisionComponent : CollisionComponent, IEntityData<FrostySdk.Ebx.CapsuleCollisionComponentData>
	{
		public new FrostySdk.Ebx.CapsuleCollisionComponentData Data => data as FrostySdk.Ebx.CapsuleCollisionComponentData;
		public override string DisplayName => "CapsuleCollisionComponent";

		public CapsuleCollisionComponent(FrostySdk.Ebx.CapsuleCollisionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

