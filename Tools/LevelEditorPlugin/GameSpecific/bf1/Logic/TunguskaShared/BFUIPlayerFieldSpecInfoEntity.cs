namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerFieldSpecInfoEntityData))]
public class BFUIPlayerFieldSpecInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerFieldSpecInfoEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerFieldSpecInfoEntityData Data => data as FrostySdk.Ebx.BFUIPlayerFieldSpecInfoEntityData;
    public override string DisplayName => "BFUIPlayerFieldSpecInfo";

    public BFUIPlayerFieldSpecInfoEntity(FrostySdk.Ebx.BFUIPlayerFieldSpecInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

