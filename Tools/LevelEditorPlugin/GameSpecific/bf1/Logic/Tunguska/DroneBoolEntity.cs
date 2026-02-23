namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroneBoolEntityData))]
public class DroneBoolEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DroneBoolEntityData>
{
    public new FrostySdk.Ebx.DroneBoolEntityData Data => data as FrostySdk.Ebx.DroneBoolEntityData;
    public override string DisplayName => "DroneBool";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DroneBoolEntity(FrostySdk.Ebx.DroneBoolEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

