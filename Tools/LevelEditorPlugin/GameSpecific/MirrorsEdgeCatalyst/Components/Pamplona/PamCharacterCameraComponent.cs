
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterCameraComponentData))]
	public class PamCharacterCameraComponent : CharacterCameraComponent, IEntityData<FrostySdk.Ebx.PamCharacterCameraComponentData>
	{
		public new FrostySdk.Ebx.PamCharacterCameraComponentData Data => data as FrostySdk.Ebx.PamCharacterCameraComponentData;
		public override string DisplayName => "PamCharacterCameraComponent";

		public PamCharacterCameraComponent(FrostySdk.Ebx.PamCharacterCameraComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

