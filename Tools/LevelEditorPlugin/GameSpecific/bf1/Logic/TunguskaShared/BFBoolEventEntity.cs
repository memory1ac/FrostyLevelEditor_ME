namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFBoolEventEntityData))]
public class BFBoolEventEntity : BoolEntity, IEntityData<FrostySdk.Ebx.BFBoolEventEntityData>
{
    public new FrostySdk.Ebx.BFBoolEventEntityData Data => data as FrostySdk.Ebx.BFBoolEventEntityData;
    public override string DisplayName => "BFBoolEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFBoolEventEntity(FrostySdk.Ebx.BFBoolEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

