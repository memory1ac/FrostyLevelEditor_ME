namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapWorldViewEntityData))]
public class BFUIElementMinimapWorldViewEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapWorldViewEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapWorldViewEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapWorldViewEntityData;
    public override string DisplayName => "BFUIElementMinimapWorldView";

    public BFUIElementMinimapWorldViewEntity(FrostySdk.Ebx.BFUIElementMinimapWorldViewEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

