namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIGetPlayerFromEventEntityData))]
public class BFUIGetPlayerFromEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIGetPlayerFromEventEntityData>
{
    public new FrostySdk.Ebx.BFUIGetPlayerFromEventEntityData Data => data as FrostySdk.Ebx.BFUIGetPlayerFromEventEntityData;
    public override string DisplayName => "BFUIGetPlayerFromEvent";

    public BFUIGetPlayerFromEventEntity(FrostySdk.Ebx.BFUIGetPlayerFromEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

