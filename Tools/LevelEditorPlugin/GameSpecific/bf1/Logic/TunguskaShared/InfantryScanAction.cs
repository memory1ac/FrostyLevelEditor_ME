namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.InfantryScanActionData))]
public class InfantryScanAction : RadarScanAction, IEntityData<FrostySdk.Ebx.InfantryScanActionData>
{
    public new FrostySdk.Ebx.InfantryScanActionData Data => data as FrostySdk.Ebx.InfantryScanActionData;
    public override string DisplayName => "InfantryScanAction";

    public InfantryScanAction(FrostySdk.Ebx.InfantryScanActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

