namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementCircularCompassEntityData))]
public class BFUIElementCircularCompassEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementCircularCompassEntityData>
{
    public new FrostySdk.Ebx.BFUIElementCircularCompassEntityData Data => data as FrostySdk.Ebx.BFUIElementCircularCompassEntityData;
    public override string DisplayName => "BFUIElementCircularCompass";

    public BFUIElementCircularCompassEntity(FrostySdk.Ebx.BFUIElementCircularCompassEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

