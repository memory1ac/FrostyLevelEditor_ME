namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIControllerDisconnectedEntityData))]
public class BFUIControllerDisconnectedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUIControllerDisconnectedEntityData>
{
    public new FrostySdk.Ebx.BFUIControllerDisconnectedEntityData Data => data as FrostySdk.Ebx.BFUIControllerDisconnectedEntityData;
    public override string DisplayName => "BFUIControllerDisconnected";

    public BFUIControllerDisconnectedEntity(FrostySdk.Ebx.BFUIControllerDisconnectedEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

