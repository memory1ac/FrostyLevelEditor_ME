namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatSpringEntityData))]
public class FloatSpringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatSpringEntityData>
{
    public new FrostySdk.Ebx.FloatSpringEntityData Data => data as FrostySdk.Ebx.FloatSpringEntityData;
    public override string DisplayName => "FloatSpring";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public FloatSpringEntity(FrostySdk.Ebx.FloatSpringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

