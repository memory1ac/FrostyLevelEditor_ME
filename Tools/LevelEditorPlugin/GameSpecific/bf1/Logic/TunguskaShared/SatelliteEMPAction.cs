namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SatelliteEMPActionData))]
public class SatelliteEMPAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.SatelliteEMPActionData>
{
    public new FrostySdk.Ebx.SatelliteEMPActionData Data => data as FrostySdk.Ebx.SatelliteEMPActionData;
    public override string DisplayName => "SatelliteEMPAction";

    public SatelliteEMPAction(FrostySdk.Ebx.SatelliteEMPActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

