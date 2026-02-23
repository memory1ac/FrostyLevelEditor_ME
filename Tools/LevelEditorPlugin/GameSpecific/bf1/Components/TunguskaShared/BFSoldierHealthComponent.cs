
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSoldierHealthComponentData))]
public class BFSoldierHealthComponent : SoldierHealthComponent, IEntityData<FrostySdk.Ebx.BFSoldierHealthComponentData>
{
    public new FrostySdk.Ebx.BFSoldierHealthComponentData Data => data as FrostySdk.Ebx.BFSoldierHealthComponentData;
    public override string DisplayName => "BFSoldierHealthComponent";

    public BFSoldierHealthComponent(FrostySdk.Ebx.BFSoldierHealthComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

