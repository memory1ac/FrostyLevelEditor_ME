namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DebugVehicleIteratorEntityData))]
public class DebugVehicleIteratorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DebugVehicleIteratorEntityData>
{
    public new FrostySdk.Ebx.DebugVehicleIteratorEntityData Data => data as FrostySdk.Ebx.DebugVehicleIteratorEntityData;
    public override string DisplayName => "DebugVehicleIterator";

    public DebugVehicleIteratorEntity(FrostySdk.Ebx.DebugVehicleIteratorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

