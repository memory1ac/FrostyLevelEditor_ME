
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.HorseHealthComponentData))]
public class HorseHealthComponent : ControllableHealthComponent, IEntityData<FrostySdk.Ebx.HorseHealthComponentData>
{
    public new FrostySdk.Ebx.HorseHealthComponentData Data => data as FrostySdk.Ebx.HorseHealthComponentData;
    public override string DisplayName => "HorseHealthComponent";

    public HorseHealthComponent(FrostySdk.Ebx.HorseHealthComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

