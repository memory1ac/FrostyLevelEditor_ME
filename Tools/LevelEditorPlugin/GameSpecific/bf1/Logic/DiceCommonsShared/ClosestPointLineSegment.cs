namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClosestPointLineSegmentData))]
public class ClosestPointLineSegment : LogicEntity, IEntityData<FrostySdk.Ebx.ClosestPointLineSegmentData>
{
    public new FrostySdk.Ebx.ClosestPointLineSegmentData Data => data as FrostySdk.Ebx.ClosestPointLineSegmentData;
    public override string DisplayName => "ClosestPointLineSegment";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public ClosestPointLineSegment(FrostySdk.Ebx.ClosestPointLineSegmentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

