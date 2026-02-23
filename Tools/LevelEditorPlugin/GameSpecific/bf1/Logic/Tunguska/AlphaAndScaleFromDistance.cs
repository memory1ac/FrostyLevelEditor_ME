namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AlphaAndScaleFromDistanceData))]
public class AlphaAndScaleFromDistance : LogicEntity, IEntityData<FrostySdk.Ebx.AlphaAndScaleFromDistanceData>
{
    public new FrostySdk.Ebx.AlphaAndScaleFromDistanceData Data => data as FrostySdk.Ebx.AlphaAndScaleFromDistanceData;
    public override string DisplayName => "AlphaAndScaleFromDistance";

    public AlphaAndScaleFromDistance(FrostySdk.Ebx.AlphaAndScaleFromDistanceData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

