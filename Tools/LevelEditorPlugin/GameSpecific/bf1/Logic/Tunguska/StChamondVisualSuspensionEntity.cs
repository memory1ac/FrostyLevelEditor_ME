namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.StChamondVisualSuspensionEntityData))]
public class StChamondVisualSuspensionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StChamondVisualSuspensionEntityData>
{
    public new FrostySdk.Ebx.StChamondVisualSuspensionEntityData Data => data as FrostySdk.Ebx.StChamondVisualSuspensionEntityData;
    public override string DisplayName => "StChamondVisualSuspension";

    public StChamondVisualSuspensionEntity(FrostySdk.Ebx.StChamondVisualSuspensionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

