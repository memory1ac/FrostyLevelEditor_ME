namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PickupListenerEntityData))]
public class PickupListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PickupListenerEntityData>
{
    public new FrostySdk.Ebx.PickupListenerEntityData Data => data as FrostySdk.Ebx.PickupListenerEntityData;
    public override string DisplayName => "PickupListener";

    public PickupListenerEntity(FrostySdk.Ebx.PickupListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

