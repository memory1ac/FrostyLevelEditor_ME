namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFPlayerFilterEntityData))]
public class BFPlayerFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFPlayerFilterEntityData>
{
    public new FrostySdk.Ebx.BFPlayerFilterEntityData Data => data as FrostySdk.Ebx.BFPlayerFilterEntityData;
    public override string DisplayName => "BFPlayerFilter";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFPlayerFilterEntity(FrostySdk.Ebx.BFPlayerFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

