
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierParachuteComponentData))]
public class SoldierParachuteComponent : GameComponent, IEntityData<FrostySdk.Ebx.SoldierParachuteComponentData>
{
    public new FrostySdk.Ebx.SoldierParachuteComponentData Data => data as FrostySdk.Ebx.SoldierParachuteComponentData;
    public override string DisplayName => "SoldierParachuteComponent";

    public SoldierParachuteComponent(FrostySdk.Ebx.SoldierParachuteComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

