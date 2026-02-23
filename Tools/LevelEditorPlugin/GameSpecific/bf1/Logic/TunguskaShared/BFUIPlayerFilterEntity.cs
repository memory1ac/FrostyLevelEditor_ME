namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerFilterEntityData))]
public class BFUIPlayerFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerFilterEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerFilterEntityData Data => data as FrostySdk.Ebx.BFUIPlayerFilterEntityData;
    public override string DisplayName => "BFUIPlayerFilter";

    public BFUIPlayerFilterEntity(FrostySdk.Ebx.BFUIPlayerFilterEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

