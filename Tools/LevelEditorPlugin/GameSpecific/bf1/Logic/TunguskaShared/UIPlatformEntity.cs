namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPlatformEntityData))]
public class UIPlatformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIPlatformEntityData>
{
    public new FrostySdk.Ebx.UIPlatformEntityData Data => data as FrostySdk.Ebx.UIPlatformEntityData;
    public override string DisplayName => "UIPlatform";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIPlatformEntity(FrostySdk.Ebx.UIPlatformEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

