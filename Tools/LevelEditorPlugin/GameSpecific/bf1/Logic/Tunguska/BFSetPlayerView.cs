namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSetPlayerViewData))]
public class BFSetPlayerView : LogicEntity, IEntityData<FrostySdk.Ebx.BFSetPlayerViewData>
{
    public new FrostySdk.Ebx.BFSetPlayerViewData Data => data as FrostySdk.Ebx.BFSetPlayerViewData;
    public override string DisplayName => "BFSetPlayerView";

    public BFSetPlayerView(FrostySdk.Ebx.BFSetPlayerViewData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

