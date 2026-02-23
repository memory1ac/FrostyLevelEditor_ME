namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HorseSpringEntityData))]
public class HorseSpringEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HorseSpringEntityData>
{
    public new FrostySdk.Ebx.HorseSpringEntityData Data => data as FrostySdk.Ebx.HorseSpringEntityData;
    public override string DisplayName => "HorseSpring";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public HorseSpringEntity(FrostySdk.Ebx.HorseSpringEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

