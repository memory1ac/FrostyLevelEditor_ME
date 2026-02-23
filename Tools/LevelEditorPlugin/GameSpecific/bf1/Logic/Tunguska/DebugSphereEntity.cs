namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugSphereEntityData))]
public class DebugSphereEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugSphereEntityData>
{
    public new FrostySdk.Ebx.DebugSphereEntityData Data => data as FrostySdk.Ebx.DebugSphereEntityData;
    public override string DisplayName => "DebugSphere";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DebugSphereEntity(FrostySdk.Ebx.DebugSphereEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

