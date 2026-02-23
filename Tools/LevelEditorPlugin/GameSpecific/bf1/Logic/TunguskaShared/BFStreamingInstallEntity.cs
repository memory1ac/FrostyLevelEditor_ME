namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFStreamingInstallEntityData))]
public class BFStreamingInstallEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFStreamingInstallEntityData>
{
    public new FrostySdk.Ebx.BFStreamingInstallEntityData Data => data as FrostySdk.Ebx.BFStreamingInstallEntityData;
    public override string DisplayName => "BFStreamingInstall";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFStreamingInstallEntity(FrostySdk.Ebx.BFStreamingInstallEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

