
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DropWeaponComponentData))]
public class DropWeaponComponent : GameComponent, IEntityData<FrostySdk.Ebx.DropWeaponComponentData>
{
    public new FrostySdk.Ebx.DropWeaponComponentData Data => data as FrostySdk.Ebx.DropWeaponComponentData;
    public override string DisplayName => "DropWeaponComponent";

    public DropWeaponComponent(FrostySdk.Ebx.DropWeaponComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

