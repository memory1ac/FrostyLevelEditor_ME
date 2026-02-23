
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DOTReceiverComponentData))]
public class DOTReceiverComponent : GameComponent, IEntityData<FrostySdk.Ebx.DOTReceiverComponentData>
{
    public new FrostySdk.Ebx.DOTReceiverComponentData Data => data as FrostySdk.Ebx.DOTReceiverComponentData;
    public override string DisplayName => "DOTReceiverComponent";

    public DOTReceiverComponent(FrostySdk.Ebx.DOTReceiverComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

