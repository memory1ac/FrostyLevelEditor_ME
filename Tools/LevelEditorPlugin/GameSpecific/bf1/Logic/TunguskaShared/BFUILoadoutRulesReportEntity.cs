namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutRulesReportEntityData))]
public class BFUILoadoutRulesReportEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutRulesReportEntityData>
{
    public new FrostySdk.Ebx.BFUILoadoutRulesReportEntityData Data => data as FrostySdk.Ebx.BFUILoadoutRulesReportEntityData;
    public override string DisplayName => "BFUILoadoutRulesReport";

    public BFUILoadoutRulesReportEntity(FrostySdk.Ebx.BFUILoadoutRulesReportEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

