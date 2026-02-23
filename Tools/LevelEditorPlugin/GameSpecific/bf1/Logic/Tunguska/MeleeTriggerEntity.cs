namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MeleeTriggerEntityData))]
public class MeleeTriggerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MeleeTriggerEntityData>
{
    public new FrostySdk.Ebx.MeleeTriggerEntityData Data => data as FrostySdk.Ebx.MeleeTriggerEntityData;
    public override string DisplayName => "MeleeTrigger";

    public MeleeTriggerEntity(FrostySdk.Ebx.MeleeTriggerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

