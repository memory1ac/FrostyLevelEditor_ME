namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayAnimationListenerEntityData))]
public class PlayAnimationListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayAnimationListenerEntityData>
{
    public new FrostySdk.Ebx.PlayAnimationListenerEntityData Data => data as FrostySdk.Ebx.PlayAnimationListenerEntityData;
    public override string DisplayName => "PlayAnimationListener";

    public PlayAnimationListenerEntity(FrostySdk.Ebx.PlayAnimationListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

