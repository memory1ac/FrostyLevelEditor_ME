
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamCharacterCustomizationComponentData))]
	public class PamCharacterCustomizationComponent : CharacterCustomizationComponent, IEntityData<FrostySdk.Ebx.PamCharacterCustomizationComponentData>
	{
		public new FrostySdk.Ebx.PamCharacterCustomizationComponentData Data => data as FrostySdk.Ebx.PamCharacterCustomizationComponentData;
		public override string DisplayName => "PamCharacterCustomizationComponent";

		public PamCharacterCustomizationComponent(FrostySdk.Ebx.PamCharacterCustomizationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

