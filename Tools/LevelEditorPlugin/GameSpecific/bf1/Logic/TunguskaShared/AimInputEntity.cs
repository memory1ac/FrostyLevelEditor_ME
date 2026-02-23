namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AimInputEntityData))]
public class AimInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AimInputEntityData>
{
    public new FrostySdk.Ebx.AimInputEntityData Data => data as FrostySdk.Ebx.AimInputEntityData;
    public override string DisplayName => "AimInput";

    public AimInputEntity(FrostySdk.Ebx.AimInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

