namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FactionEntityData))]
public class FactionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FactionEntityData>
{
    public new FrostySdk.Ebx.FactionEntityData Data => data as FrostySdk.Ebx.FactionEntityData;
    public override string DisplayName => "Faction";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FactionEntity(FrostySdk.Ebx.FactionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

