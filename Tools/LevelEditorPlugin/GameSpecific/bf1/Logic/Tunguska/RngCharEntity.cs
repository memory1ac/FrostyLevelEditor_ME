namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.RngCharEntityData))]
public class RngCharEntity : LogicEntity, IEntityData<FrostySdk.Ebx.RngCharEntityData>
{
    public new FrostySdk.Ebx.RngCharEntityData Data => data as FrostySdk.Ebx.RngCharEntityData;
    public override string DisplayName => "RngChar";

    public RngCharEntity(FrostySdk.Ebx.RngCharEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

