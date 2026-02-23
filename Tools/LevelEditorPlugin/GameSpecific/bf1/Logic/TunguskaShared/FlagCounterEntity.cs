namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlagCounterEntityData))]
public class FlagCounterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FlagCounterEntityData>
{
    public new FrostySdk.Ebx.FlagCounterEntityData Data => data as FrostySdk.Ebx.FlagCounterEntityData;
    public override string DisplayName => "FlagCounter";

    public FlagCounterEntity(FrostySdk.Ebx.FlagCounterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

