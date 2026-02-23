
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PamWeaponDynamicModelHealthComponentData))]
	public class PamWeaponDynamicModelHealthComponent : DynamicModelHealthComponent, IEntityData<FrostySdk.Ebx.PamWeaponDynamicModelHealthComponentData>
	{
		public new FrostySdk.Ebx.PamWeaponDynamicModelHealthComponentData Data => data as FrostySdk.Ebx.PamWeaponDynamicModelHealthComponentData;
		public override string DisplayName => "PamWeaponDynamicModelHealthComponent";

		public PamWeaponDynamicModelHealthComponent(FrostySdk.Ebx.PamWeaponDynamicModelHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

