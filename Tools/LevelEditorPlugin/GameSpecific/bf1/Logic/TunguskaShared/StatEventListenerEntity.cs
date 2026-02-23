namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.StatEventListenerEntityData))]
public class StatEventListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StatEventListenerEntityData>
{
    public new FrostySdk.Ebx.StatEventListenerEntityData Data => data as FrostySdk.Ebx.StatEventListenerEntityData;
    public override string DisplayName => "StatEventListener";

    public StatEventListenerEntity(FrostySdk.Ebx.StatEventListenerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

