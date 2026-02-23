
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameVoiceOverAnimationComponentData))]
	public class GameVoiceOverAnimationComponent : GameComponent, IEntityData<FrostySdk.Ebx.GameVoiceOverAnimationComponentData>
	{
		public new FrostySdk.Ebx.GameVoiceOverAnimationComponentData Data => data as FrostySdk.Ebx.GameVoiceOverAnimationComponentData;
		public override string DisplayName => "GameVoiceOverAnimationComponent";

		public GameVoiceOverAnimationComponent(FrostySdk.Ebx.GameVoiceOverAnimationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

