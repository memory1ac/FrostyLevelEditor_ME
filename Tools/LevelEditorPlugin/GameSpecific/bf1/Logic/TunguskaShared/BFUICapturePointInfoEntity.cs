namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUICapturePointInfoEntityData))]
public class BFUICapturePointInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUICapturePointInfoEntityData>
{
    public new FrostySdk.Ebx.BFUICapturePointInfoEntityData Data => data as FrostySdk.Ebx.BFUICapturePointInfoEntityData;
    public override string DisplayName => "BFUICapturePointInfo";

    public BFUICapturePointInfoEntity(FrostySdk.Ebx.BFUICapturePointInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

