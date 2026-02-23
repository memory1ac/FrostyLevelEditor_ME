namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SectorEntityData))]
public class SectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SectorEntityData>
{
    public new FrostySdk.Ebx.SectorEntityData Data => data as FrostySdk.Ebx.SectorEntityData;
    public override string DisplayName => "Sector";

    public SectorEntity(FrostySdk.Ebx.SectorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

