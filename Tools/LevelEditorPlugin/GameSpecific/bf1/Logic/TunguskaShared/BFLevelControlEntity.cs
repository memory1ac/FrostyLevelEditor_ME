namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFLevelControlEntityData))]
public class BFLevelControlEntity : LevelControlEntity, IEntityData<FrostySdk.Ebx.BFLevelControlEntityData>
{
    public new FrostySdk.Ebx.BFLevelControlEntityData Data => data as FrostySdk.Ebx.BFLevelControlEntityData;
    public override string DisplayName => "BFLevelControl";

    public BFLevelControlEntity(FrostySdk.Ebx.BFLevelControlEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

