namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ComparePlayerEntityData))]
public class ComparePlayerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ComparePlayerEntityData>
{
    public new FrostySdk.Ebx.ComparePlayerEntityData Data => data as FrostySdk.Ebx.ComparePlayerEntityData;
    public override string DisplayName => "ComparePlayer";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ComparePlayerEntity(FrostySdk.Ebx.ComparePlayerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

