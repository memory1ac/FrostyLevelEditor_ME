namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FireEventEntityData))]
public class FireEventEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FireEventEntityData>
{
    public new FrostySdk.Ebx.FireEventEntityData Data => data as FrostySdk.Ebx.FireEventEntityData;
    public override string DisplayName => "FireEvent";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FireEventEntity(FrostySdk.Ebx.FireEventEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

