namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BipodEntityData))]
public class BipodEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BipodEntityData>
{
    public new FrostySdk.Ebx.BipodEntityData Data => data as FrostySdk.Ebx.BipodEntityData;
    public override string DisplayName => "Bipod";

    public BipodEntity(FrostySdk.Ebx.BipodEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

