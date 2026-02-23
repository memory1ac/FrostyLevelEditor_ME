namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIStreamingInstallEntityData))]
public class BFUIStreamingInstallEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIStreamingInstallEntityData>
{
    public new FrostySdk.Ebx.BFUIStreamingInstallEntityData Data => data as FrostySdk.Ebx.BFUIStreamingInstallEntityData;
    public override string DisplayName => "BFUIStreamingInstall";

    public BFUIStreamingInstallEntity(FrostySdk.Ebx.BFUIStreamingInstallEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

