namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerInfoEntityData))]
public class BFUIPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerInfoEntityData;
    public override string DisplayName => "BFUIPlayerInfo";

    public BFUIPlayerInfoEntity(FrostySdk.Ebx.BFUIPlayerInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

