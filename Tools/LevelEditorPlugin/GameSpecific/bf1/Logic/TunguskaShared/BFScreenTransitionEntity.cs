namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFScreenTransitionEntityData))]
public class BFScreenTransitionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFScreenTransitionEntityData>
{
    public new FrostySdk.Ebx.BFScreenTransitionEntityData Data => data as FrostySdk.Ebx.BFScreenTransitionEntityData;
    public override string DisplayName => "BFScreenTransition";

    public BFScreenTransitionEntity(FrostySdk.Ebx.BFScreenTransitionEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

