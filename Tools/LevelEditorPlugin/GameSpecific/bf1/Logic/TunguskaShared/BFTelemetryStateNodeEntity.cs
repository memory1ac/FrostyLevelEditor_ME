namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFTelemetryStateNodeEntityData))]
public class BFTelemetryStateNodeEntity : StateNodeEntity, IEntityData<FrostySdk.Ebx.BFTelemetryStateNodeEntityData>
{
    public new FrostySdk.Ebx.BFTelemetryStateNodeEntityData Data => data as FrostySdk.Ebx.BFTelemetryStateNodeEntityData;
    public override string DisplayName => "BFTelemetryStateNode";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFTelemetryStateNodeEntity(FrostySdk.Ebx.BFTelemetryStateNodeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

