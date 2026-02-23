namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIWorldIconBehaviorEntityData))]
public class BFUIWorldIconBehaviorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIWorldIconBehaviorEntityData>
{
    public new FrostySdk.Ebx.BFUIWorldIconBehaviorEntityData Data => data as FrostySdk.Ebx.BFUIWorldIconBehaviorEntityData;
    public override string DisplayName => "BFUIWorldIconBehavior";

    public BFUIWorldIconBehaviorEntity(FrostySdk.Ebx.BFUIWorldIconBehaviorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

