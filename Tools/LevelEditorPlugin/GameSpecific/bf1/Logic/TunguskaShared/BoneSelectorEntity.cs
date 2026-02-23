namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BoneSelectorEntityData))]
public class BoneSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BoneSelectorEntityData>
{
    public new FrostySdk.Ebx.BoneSelectorEntityData Data => data as FrostySdk.Ebx.BoneSelectorEntityData;
    public override string DisplayName => "BoneSelector";

    public BoneSelectorEntity(FrostySdk.Ebx.BoneSelectorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

