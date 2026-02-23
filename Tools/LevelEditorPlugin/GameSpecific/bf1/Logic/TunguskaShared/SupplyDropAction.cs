namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SupplyDropActionData))]
public class SupplyDropAction : CommanderActionBase, IEntityData<FrostySdk.Ebx.SupplyDropActionData>
{
    public new FrostySdk.Ebx.SupplyDropActionData Data => data as FrostySdk.Ebx.SupplyDropActionData;
    public override string DisplayName => "SupplyDropAction";

    public SupplyDropAction(FrostySdk.Ebx.SupplyDropActionData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

