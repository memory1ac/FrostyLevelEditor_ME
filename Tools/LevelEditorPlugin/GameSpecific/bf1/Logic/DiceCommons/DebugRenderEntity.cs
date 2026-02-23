namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugRenderEntityData))]
public class DebugRenderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugRenderEntityData>
{
    public new FrostySdk.Ebx.DebugRenderEntityData Data => data as FrostySdk.Ebx.DebugRenderEntityData;
    public override string DisplayName => "DebugRender";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public DebugRenderEntity(FrostySdk.Ebx.DebugRenderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

