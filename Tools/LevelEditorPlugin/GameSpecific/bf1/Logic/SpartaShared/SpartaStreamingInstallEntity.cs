namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpartaStreamingInstallEntityData))]
public class SpartaStreamingInstallEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpartaStreamingInstallEntityData>
{
    public new FrostySdk.Ebx.SpartaStreamingInstallEntityData Data => data as FrostySdk.Ebx.SpartaStreamingInstallEntityData;
    public override string DisplayName => "SpartaStreamingInstall";

    public SpartaStreamingInstallEntity(FrostySdk.Ebx.SpartaStreamingInstallEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

