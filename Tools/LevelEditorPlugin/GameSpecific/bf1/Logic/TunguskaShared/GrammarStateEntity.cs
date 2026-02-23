namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GrammarStateEntityData))]
public class GrammarStateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GrammarStateEntityData>
{
    public new FrostySdk.Ebx.GrammarStateEntityData Data => data as FrostySdk.Ebx.GrammarStateEntityData;
    public override string DisplayName => "GrammarState";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public GrammarStateEntity(FrostySdk.Ebx.GrammarStateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

