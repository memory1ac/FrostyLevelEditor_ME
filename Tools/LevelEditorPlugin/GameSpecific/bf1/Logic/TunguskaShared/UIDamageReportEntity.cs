namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIDamageReportEntityData))]
public class UIDamageReportEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIDamageReportEntityData>
{
    public new FrostySdk.Ebx.UIDamageReportEntityData Data => data as FrostySdk.Ebx.UIDamageReportEntityData;
    public override string DisplayName => "UIDamageReport";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIDamageReportEntity(FrostySdk.Ebx.UIDamageReportEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

