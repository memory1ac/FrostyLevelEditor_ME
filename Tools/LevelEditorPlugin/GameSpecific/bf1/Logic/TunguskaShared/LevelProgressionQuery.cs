namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevelProgressionQueryData))]
public class LevelProgressionQuery : LogicEntity, IEntityData<FrostySdk.Ebx.LevelProgressionQueryData>
{
    public new FrostySdk.Ebx.LevelProgressionQueryData Data => data as FrostySdk.Ebx.LevelProgressionQueryData;
    public override string DisplayName => "LevelProgressionQuery";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public LevelProgressionQuery(FrostySdk.Ebx.LevelProgressionQueryData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

