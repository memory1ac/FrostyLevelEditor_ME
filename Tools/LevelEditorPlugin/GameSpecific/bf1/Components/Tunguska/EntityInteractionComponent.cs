
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.EntityInteractionComponentData))]
public class EntityInteractionComponent : GameComponent, IEntityData<FrostySdk.Ebx.EntityInteractionComponentData>
{
    public new FrostySdk.Ebx.EntityInteractionComponentData Data => data as FrostySdk.Ebx.EntityInteractionComponentData;
    public override string DisplayName => "EntityInteractionComponent";

    public EntityInteractionComponent(FrostySdk.Ebx.EntityInteractionComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

