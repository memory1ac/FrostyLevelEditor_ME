namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FieldKitDropAction01Data))]
public class FieldKitDropAction01 : FieldKitDropActionBase, IEntityData<FrostySdk.Ebx.FieldKitDropAction01Data>
{
    public new FrostySdk.Ebx.FieldKitDropAction01Data Data => data as FrostySdk.Ebx.FieldKitDropAction01Data;
    public override string DisplayName => "FieldKitDropAction01";

    public FieldKitDropAction01(FrostySdk.Ebx.FieldKitDropAction01Data inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

