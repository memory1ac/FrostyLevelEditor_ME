
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BaseSwarmComponentData))]
	public class BaseSwarmComponent : GameComponent, IEntityData<FrostySdk.Ebx.BaseSwarmComponentData>
	{
		public new FrostySdk.Ebx.BaseSwarmComponentData Data => data as FrostySdk.Ebx.BaseSwarmComponentData;
		public override string DisplayName => "BaseSwarmComponent";

		public BaseSwarmComponent(FrostySdk.Ebx.BaseSwarmComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

