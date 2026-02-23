namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.QueryTimeEntityData))]
public class QueryTimeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.QueryTimeEntityData>
{
    public new FrostySdk.Ebx.QueryTimeEntityData Data => data as FrostySdk.Ebx.QueryTimeEntityData;
    public override string DisplayName => "QueryTime";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public QueryTimeEntity(FrostySdk.Ebx.QueryTimeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

