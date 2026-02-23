namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeltaFloatEntityData))]
public class DeltaFloatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeltaFloatEntityData>
{
    public new FrostySdk.Ebx.DeltaFloatEntityData Data => data as FrostySdk.Ebx.DeltaFloatEntityData;
    public override string DisplayName => "DeltaFloat";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DeltaFloatEntity(FrostySdk.Ebx.DeltaFloatEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

