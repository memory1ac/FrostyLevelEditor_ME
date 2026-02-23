namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIPlayerChooserEntityData))]
public class BFUIPlayerChooserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIPlayerChooserEntityData>
{
    public new FrostySdk.Ebx.BFUIPlayerChooserEntityData Data => data as FrostySdk.Ebx.BFUIPlayerChooserEntityData;
    public override string DisplayName => "BFUIPlayerChooser";

    public BFUIPlayerChooserEntity(FrostySdk.Ebx.BFUIPlayerChooserEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

