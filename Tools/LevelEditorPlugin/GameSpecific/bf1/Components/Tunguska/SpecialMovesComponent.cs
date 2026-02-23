
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpecialMovesComponentData))]
public class SpecialMovesComponent : GameComponent, IEntityData<FrostySdk.Ebx.SpecialMovesComponentData>
{
    public new FrostySdk.Ebx.SpecialMovesComponentData Data => data as FrostySdk.Ebx.SpecialMovesComponentData;
    public override string DisplayName => "SpecialMovesComponent";

    public SpecialMovesComponent(FrostySdk.Ebx.SpecialMovesComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

