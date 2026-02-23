namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugTestEntityData))]
public class DebugTestEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugTestEntityData>
{
    public new FrostySdk.Ebx.DebugTestEntityData Data => data as FrostySdk.Ebx.DebugTestEntityData;
    public override string DisplayName => "DebugTest";

    public DebugTestEntity(FrostySdk.Ebx.DebugTestEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

