namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LifeCounterEntityData))]
public class LifeCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LifeCounterEntityData>
{
    public new FrostySdk.Ebx.LifeCounterEntityData Data => data as FrostySdk.Ebx.LifeCounterEntityData;
    public override string DisplayName => "LifeCounter";

    public LifeCounterEntity(FrostySdk.Ebx.LifeCounterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

