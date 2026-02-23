
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamWeaponFiringComponentData))]
	public class PamWeaponFiringComponent : GameComponent, IEntityData<FrostySdk.Ebx.PamWeaponFiringComponentData>
	{
		public new FrostySdk.Ebx.PamWeaponFiringComponentData Data => data as FrostySdk.Ebx.PamWeaponFiringComponentData;
		public override string DisplayName => "PamWeaponFiringComponent";

		public PamWeaponFiringComponent(FrostySdk.Ebx.PamWeaponFiringComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

