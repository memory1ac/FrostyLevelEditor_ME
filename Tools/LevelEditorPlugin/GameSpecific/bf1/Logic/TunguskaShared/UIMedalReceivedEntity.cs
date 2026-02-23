namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMedalReceivedEntityData))]
public class UIMedalReceivedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMedalReceivedEntityData>
{
    public new FrostySdk.Ebx.UIMedalReceivedEntityData Data => data as FrostySdk.Ebx.UIMedalReceivedEntityData;
    public override string DisplayName => "UIMedalReceived";

    public UIMedalReceivedEntity(FrostySdk.Ebx.UIMedalReceivedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

