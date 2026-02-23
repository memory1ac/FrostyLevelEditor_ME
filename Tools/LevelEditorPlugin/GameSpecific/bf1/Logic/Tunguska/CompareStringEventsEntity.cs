namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareStringEventsEntityData))]
public class CompareStringEventsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompareStringEventsEntityData>
{
    public new FrostySdk.Ebx.CompareStringEventsEntityData Data => data as FrostySdk.Ebx.CompareStringEventsEntityData;
    public override string DisplayName => "CompareStringEvents";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public CompareStringEventsEntity(FrostySdk.Ebx.CompareStringEventsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

