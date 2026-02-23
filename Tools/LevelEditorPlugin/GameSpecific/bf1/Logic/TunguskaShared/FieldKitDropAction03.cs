namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FieldKitDropAction03Data))]
public class FieldKitDropAction03 : FieldKitDropActionBase, IEntityData<FrostySdk.Ebx.FieldKitDropAction03Data>
{
    public new FrostySdk.Ebx.FieldKitDropAction03Data Data => data as FrostySdk.Ebx.FieldKitDropAction03Data;
    public override string DisplayName => "FieldKitDropAction03";

    public FieldKitDropAction03(FrostySdk.Ebx.FieldKitDropAction03Data inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

