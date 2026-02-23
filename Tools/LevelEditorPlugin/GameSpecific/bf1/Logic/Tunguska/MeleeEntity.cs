namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.MeleeEntityData))]
public class MeleeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MeleeEntityData>
{
    public new FrostySdk.Ebx.MeleeEntityData Data => data as FrostySdk.Ebx.MeleeEntityData;
    public override string DisplayName => "Melee";

    public MeleeEntity(FrostySdk.Ebx.MeleeEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

