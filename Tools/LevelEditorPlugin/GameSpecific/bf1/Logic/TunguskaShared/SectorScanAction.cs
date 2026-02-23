namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SectorScanActionData))]
public class SectorScanAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.SectorScanActionData>
{
    public new FrostySdk.Ebx.SectorScanActionData Data => data as FrostySdk.Ebx.SectorScanActionData;
    public override string DisplayName => "SectorScanAction";

    public SectorScanAction(FrostySdk.Ebx.SectorScanActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

