namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevelProgressEntityData))]
public class LevelProgressEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LevelProgressEntityData>
{
    public new FrostySdk.Ebx.LevelProgressEntityData Data => data as FrostySdk.Ebx.LevelProgressEntityData;
    public override string DisplayName => "LevelProgress";

    public LevelProgressEntity(FrostySdk.Ebx.LevelProgressEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

