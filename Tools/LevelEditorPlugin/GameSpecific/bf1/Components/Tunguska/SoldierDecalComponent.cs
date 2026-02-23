
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierDecalComponentData))]
public class SoldierDecalComponent : GameComponent, IEntityData<FrostySdk.Ebx.SoldierDecalComponentData>
{
    public new FrostySdk.Ebx.SoldierDecalComponentData Data => data as FrostySdk.Ebx.SoldierDecalComponentData;
    public override string DisplayName => "SoldierDecalComponent";

    public SoldierDecalComponent(FrostySdk.Ebx.SoldierDecalComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

