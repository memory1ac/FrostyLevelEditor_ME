namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIAvailableKitBuildsEntityData))]
public class BFUIAvailableKitBuildsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIAvailableKitBuildsEntityData>
{
    public new FrostySdk.Ebx.BFUIAvailableKitBuildsEntityData Data => data as FrostySdk.Ebx.BFUIAvailableKitBuildsEntityData;
    public override string DisplayName => "BFUIAvailableKitBuilds";

    public BFUIAvailableKitBuildsEntity(FrostySdk.Ebx.BFUIAvailableKitBuildsEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

