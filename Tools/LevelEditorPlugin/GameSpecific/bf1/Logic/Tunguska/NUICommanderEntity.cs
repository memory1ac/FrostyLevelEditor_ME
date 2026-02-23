namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.NUICommanderEntityData))]
public class NUICommanderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.NUICommanderEntityData>
{
    public new FrostySdk.Ebx.NUICommanderEntityData Data => data as FrostySdk.Ebx.NUICommanderEntityData;
    public override string DisplayName => "NUICommander";

    public NUICommanderEntity(FrostySdk.Ebx.NUICommanderEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

