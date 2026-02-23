namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILevelTransitionGateEntityData))]
public class UILevelTransitionGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILevelTransitionGateEntityData>
{
    public new FrostySdk.Ebx.UILevelTransitionGateEntityData Data => data as FrostySdk.Ebx.UILevelTransitionGateEntityData;
    public override string DisplayName => "UILevelTransitionGate";

    public UILevelTransitionGateEntity(FrostySdk.Ebx.UILevelTransitionGateEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

