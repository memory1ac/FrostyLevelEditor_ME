namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AwardDataEntityData))]
public class AwardDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AwardDataEntityData>
{
    public new FrostySdk.Ebx.AwardDataEntityData Data => data as FrostySdk.Ebx.AwardDataEntityData;
    public override string DisplayName => "AwardData";

    public AwardDataEntity(FrostySdk.Ebx.AwardDataEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

