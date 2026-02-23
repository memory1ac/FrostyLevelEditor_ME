namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetLoadoutUnlockData))]
public class BFUIGetLoadoutUnlock : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetLoadoutUnlockData>
{
    public new FrostySdk.Ebx.BFUIGetLoadoutUnlockData Data => data as FrostySdk.Ebx.BFUIGetLoadoutUnlockData;
    public override string DisplayName => "BFUIGetLoadoutUnlock";

    public BFUIGetLoadoutUnlock(FrostySdk.Ebx.BFUIGetLoadoutUnlockData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

