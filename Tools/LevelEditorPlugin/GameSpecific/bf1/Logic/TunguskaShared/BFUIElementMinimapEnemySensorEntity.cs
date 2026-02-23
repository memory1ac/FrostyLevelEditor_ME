namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapEnemySensorEntityData))]
public class BFUIElementMinimapEnemySensorEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapEnemySensorEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapEnemySensorEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapEnemySensorEntityData;
    public override string DisplayName => "BFUIElementMinimapEnemySensor";

    public BFUIElementMinimapEnemySensorEntity(FrostySdk.Ebx.BFUIElementMinimapEnemySensorEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

