namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerVoipInfoEntityData))]
public class BFUIPlayerVoipInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerVoipInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerVoipInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerVoipInfoEntityData;
    public override string DisplayName => "BFUIPlayerVoipInfo";

    public BFUIPlayerVoipInfoEntity(FrostySdk.Ebx.BFUIPlayerVoipInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

