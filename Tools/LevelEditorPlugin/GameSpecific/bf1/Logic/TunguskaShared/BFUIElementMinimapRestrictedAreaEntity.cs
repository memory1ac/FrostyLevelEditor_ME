namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapRestrictedAreaEntityData))]
public class BFUIElementMinimapRestrictedAreaEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapRestrictedAreaEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapRestrictedAreaEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapRestrictedAreaEntityData;
    public override string DisplayName => "BFUIElementMinimapRestrictedArea";

    public BFUIElementMinimapRestrictedAreaEntity(FrostySdk.Ebx.BFUIElementMinimapRestrictedAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

