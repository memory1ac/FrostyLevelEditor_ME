namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OperationStateEntityData))]
public class OperationStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OperationStateEntityData>
{
    public new FrostySdk.Ebx.OperationStateEntityData Data => data as FrostySdk.Ebx.OperationStateEntityData;
    public override string DisplayName => "OperationState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public OperationStateEntity(FrostySdk.Ebx.OperationStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

