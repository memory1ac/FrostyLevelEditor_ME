namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.CarVisualSuspensionEntityData))]
public class CarVisualSuspensionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CarVisualSuspensionEntityData>
{
    public new FrostySdk.Ebx.CarVisualSuspensionEntityData Data => data as FrostySdk.Ebx.CarVisualSuspensionEntityData;
    public override string DisplayName => "CarVisualSuspension";

    public CarVisualSuspensionEntity(FrostySdk.Ebx.CarVisualSuspensionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

