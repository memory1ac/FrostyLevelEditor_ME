namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICapturePointFilterEntityData))]
public class BFUICapturePointFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUICapturePointFilterEntityData>
{
    public new FrostySdk.Ebx.BFUICapturePointFilterEntityData Data => data as FrostySdk.Ebx.BFUICapturePointFilterEntityData;
    public override string DisplayName => "BFUICapturePointFilter";

    public BFUICapturePointFilterEntity(FrostySdk.Ebx.BFUICapturePointFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

