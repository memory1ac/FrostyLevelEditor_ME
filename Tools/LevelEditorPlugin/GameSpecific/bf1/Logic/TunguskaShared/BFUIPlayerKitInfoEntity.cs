namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerKitInfoEntityData))]
public class BFUIPlayerKitInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerKitInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerKitInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerKitInfoEntityData;
    public override string DisplayName => "BFUIPlayerKitInfo";

    public BFUIPlayerKitInfoEntity(FrostySdk.Ebx.BFUIPlayerKitInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

