namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FieldKitDropActionBaseData))]
public class FieldKitDropActionBase : CommanderActionBase, IEntityData<FrostySdk.Ebx.FieldKitDropActionBaseData>
{
    public new FrostySdk.Ebx.FieldKitDropActionBaseData Data => data as FrostySdk.Ebx.FieldKitDropActionBaseData;
    public override string DisplayName => "FieldKitDropActionBase";

    public FieldKitDropActionBase(FrostySdk.Ebx.FieldKitDropActionBaseData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

