
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerLogoComponentData))]
public class PlayerLogoComponent : ShaderParameterComponent, IEntityData<FrostySdk.Ebx.PlayerLogoComponentData>
{
    public new FrostySdk.Ebx.PlayerLogoComponentData Data => data as FrostySdk.Ebx.PlayerLogoComponentData;
    public override string DisplayName => "PlayerLogoComponent";

    public PlayerLogoComponent(FrostySdk.Ebx.PlayerLogoComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

