namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FieldKitDropAction02Data))]
public class FieldKitDropAction02 : FieldKitDropActionBase, IEntityData<FrostySdk.Ebx.FieldKitDropAction02Data>
{
    public new FrostySdk.Ebx.FieldKitDropAction02Data Data => data as FrostySdk.Ebx.FieldKitDropAction02Data;
    public override string DisplayName => "FieldKitDropAction02";

    public FieldKitDropAction02(FrostySdk.Ebx.FieldKitDropAction02Data inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

