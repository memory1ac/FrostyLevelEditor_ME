namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AiAimInputEntityData))]
public class AiAimInputEntity : AimInputEntity, IEntityData<FrostySdk.Ebx.AiAimInputEntityData>
{
    public new FrostySdk.Ebx.AiAimInputEntityData Data => data as FrostySdk.Ebx.AiAimInputEntityData;
    public override string DisplayName => "AiAimInput";

    public AiAimInputEntity(FrostySdk.Ebx.AiAimInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

