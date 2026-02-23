namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ReportProgressEntityData))]
public class ReportProgressEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ReportProgressEntityData>
{
    public new FrostySdk.Ebx.ReportProgressEntityData Data => data as FrostySdk.Ebx.ReportProgressEntityData;
    public override string DisplayName => "ReportProgress";

    public ReportProgressEntity(FrostySdk.Ebx.ReportProgressEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

