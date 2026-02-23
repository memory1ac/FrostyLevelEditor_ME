namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIAvailableUnlocksEntityData))]
public class BFUIAvailableUnlocksEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIAvailableUnlocksEntityData>
{
    public new FrostySdk.Ebx.BFUIAvailableUnlocksEntityData Data => data as FrostySdk.Ebx.BFUIAvailableUnlocksEntityData;
    public override string DisplayName => "BFUIAvailableUnlocks";

    public BFUIAvailableUnlocksEntity(FrostySdk.Ebx.BFUIAvailableUnlocksEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

