namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ExitReasonEntityData))]
public class ExitReasonEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ExitReasonEntityData>
{
    public new FrostySdk.Ebx.ExitReasonEntityData Data => data as FrostySdk.Ebx.ExitReasonEntityData;
    public override string DisplayName => "ExitReason";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ExitReasonEntity(FrostySdk.Ebx.ExitReasonEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

