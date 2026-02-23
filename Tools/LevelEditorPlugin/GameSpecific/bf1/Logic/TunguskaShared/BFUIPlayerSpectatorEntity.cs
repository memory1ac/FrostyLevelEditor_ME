namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerSpectatorEntityData))]
public class BFUIPlayerSpectatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerSpectatorEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerSpectatorEntityData Data => data as FrostySdk.Ebx.BFUIPlayerSpectatorEntityData;
    public override string DisplayName => "BFUIPlayerSpectator";

    public BFUIPlayerSpectatorEntity(FrostySdk.Ebx.BFUIPlayerSpectatorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

