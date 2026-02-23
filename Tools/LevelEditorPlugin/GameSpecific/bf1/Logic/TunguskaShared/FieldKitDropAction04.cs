namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FieldKitDropAction04Data))]
public class FieldKitDropAction04 : FieldKitDropActionBase, IEntityData<FrostySdk.Ebx.FieldKitDropAction04Data>
{
    public new FrostySdk.Ebx.FieldKitDropAction04Data Data => data as FrostySdk.Ebx.FieldKitDropAction04Data;
    public override string DisplayName => "FieldKitDropAction04";

    public FieldKitDropAction04(FrostySdk.Ebx.FieldKitDropAction04Data inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

