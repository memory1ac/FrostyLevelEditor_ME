namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ReportEmblemEntityData))]
public class ReportEmblemEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ReportEmblemEntityData>
{
    public new FrostySdk.Ebx.ReportEmblemEntityData Data => data as FrostySdk.Ebx.ReportEmblemEntityData;
    public override string DisplayName => "ReportEmblem";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ReportEmblemEntity(FrostySdk.Ebx.ReportEmblemEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

