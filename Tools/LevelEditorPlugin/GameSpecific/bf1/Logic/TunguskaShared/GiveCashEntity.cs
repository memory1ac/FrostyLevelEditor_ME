namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.GiveCashEntityData))]
public class GiveCashEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GiveCashEntityData>
{
    public new FrostySdk.Ebx.GiveCashEntityData Data => data as FrostySdk.Ebx.GiveCashEntityData;
    public override string DisplayName => "GiveCash";

    public GiveCashEntity(FrostySdk.Ebx.GiveCashEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

