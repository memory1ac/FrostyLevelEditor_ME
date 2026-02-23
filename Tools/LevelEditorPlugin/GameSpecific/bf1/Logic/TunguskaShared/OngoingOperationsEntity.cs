namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.OngoingOperationsEntityData))]
public class OngoingOperationsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OngoingOperationsEntityData>
{
    public new FrostySdk.Ebx.OngoingOperationsEntityData Data => data as FrostySdk.Ebx.OngoingOperationsEntityData;
    public override string DisplayName => "OngoingOperations";

    public OngoingOperationsEntity(FrostySdk.Ebx.OngoingOperationsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

