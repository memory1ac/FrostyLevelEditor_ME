
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIBrainComponentData))]
	public class AIBrainComponent : GameComponent, IEntityData<FrostySdk.Ebx.AIBrainComponentData>
	{
		public new FrostySdk.Ebx.AIBrainComponentData Data => data as FrostySdk.Ebx.AIBrainComponentData;
		public override string DisplayName => "AIBrainComponent";

		public AIBrainComponent(FrostySdk.Ebx.AIBrainComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

