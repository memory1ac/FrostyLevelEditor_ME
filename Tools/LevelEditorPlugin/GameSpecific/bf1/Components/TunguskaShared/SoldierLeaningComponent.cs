
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierLeaningComponentData))]
public class SoldierLeaningComponent : GameComponent, IEntityData<FrostySdk.Ebx.SoldierLeaningComponentData>
{
    public new FrostySdk.Ebx.SoldierLeaningComponentData Data => data as FrostySdk.Ebx.SoldierLeaningComponentData;
    public override string DisplayName => "SoldierLeaningComponent";

    public SoldierLeaningComponent(FrostySdk.Ebx.SoldierLeaningComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

