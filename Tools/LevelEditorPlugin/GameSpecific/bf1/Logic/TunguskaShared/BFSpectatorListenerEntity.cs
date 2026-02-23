namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorListenerEntityData))]
public class BFSpectatorListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpectatorListenerEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorListenerEntityData Data => data as FrostySdk.Ebx.BFSpectatorListenerEntityData;
    public override string DisplayName => "BFSpectatorListener";

    public BFSpectatorListenerEntity(FrostySdk.Ebx.BFSpectatorListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

