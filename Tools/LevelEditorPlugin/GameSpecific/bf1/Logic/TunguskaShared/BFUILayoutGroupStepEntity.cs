namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILayoutGroupStepEntityData))]
public class BFUILayoutGroupStepEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILayoutGroupStepEntityData>
{
    public new FrostySdk.Ebx.BFUILayoutGroupStepEntityData Data => data as FrostySdk.Ebx.BFUILayoutGroupStepEntityData;
    public override string DisplayName => "BFUILayoutGroupStep";

    public BFUILayoutGroupStepEntity(FrostySdk.Ebx.BFUILayoutGroupStepEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

