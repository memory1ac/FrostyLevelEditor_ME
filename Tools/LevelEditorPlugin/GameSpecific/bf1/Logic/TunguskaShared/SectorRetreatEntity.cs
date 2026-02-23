namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SectorRetreatEntityData))]
public class SectorRetreatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SectorRetreatEntityData>
{
    public new FrostySdk.Ebx.SectorRetreatEntityData Data => data as FrostySdk.Ebx.SectorRetreatEntityData;
    public override string DisplayName => "SectorRetreat";

    public SectorRetreatEntity(FrostySdk.Ebx.SectorRetreatEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

