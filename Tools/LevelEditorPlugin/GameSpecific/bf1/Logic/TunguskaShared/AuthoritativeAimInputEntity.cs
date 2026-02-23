namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AuthoritativeAimInputEntityData))]
public class AuthoritativeAimInputEntity : AimInputEntity, IEntityData<FrostySdk.Ebx.AuthoritativeAimInputEntityData>
{
    public new FrostySdk.Ebx.AuthoritativeAimInputEntityData Data => data as FrostySdk.Ebx.AuthoritativeAimInputEntityData;
    public override string DisplayName => "AuthoritativeAimInput";

    public AuthoritativeAimInputEntity(FrostySdk.Ebx.AuthoritativeAimInputEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

