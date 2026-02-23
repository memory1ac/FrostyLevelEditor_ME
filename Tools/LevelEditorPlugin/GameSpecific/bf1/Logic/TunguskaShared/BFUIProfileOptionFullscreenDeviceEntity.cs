namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIProfileOptionFullscreenDeviceEntityData))]
public class BFUIProfileOptionFullscreenDeviceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIProfileOptionFullscreenDeviceEntityData>
{
    public new FrostySdk.Ebx.BFUIProfileOptionFullscreenDeviceEntityData Data => data as FrostySdk.Ebx.BFUIProfileOptionFullscreenDeviceEntityData;
    public override string DisplayName => "BFUIProfileOptionFullscreenDevice";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public BFUIProfileOptionFullscreenDeviceEntity(FrostySdk.Ebx.BFUIProfileOptionFullscreenDeviceEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

