namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SharedDataEntityData))]
public class SharedDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SharedDataEntityData>
{
    public new FrostySdk.Ebx.SharedDataEntityData Data => data as FrostySdk.Ebx.SharedDataEntityData;
    public override string DisplayName => "SharedData";

    public SharedDataEntity(FrostySdk.Ebx.SharedDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

