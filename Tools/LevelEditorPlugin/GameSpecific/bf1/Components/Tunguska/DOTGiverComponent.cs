
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.DOTGiverComponentData))]
public class DOTGiverComponent : GameComponent, IEntityData<FrostySdk.Ebx.DOTGiverComponentData>
{
    public new FrostySdk.Ebx.DOTGiverComponentData Data => data as FrostySdk.Ebx.DOTGiverComponentData;
    public override string DisplayName => "DOTGiverComponent";

    public DOTGiverComponent(FrostySdk.Ebx.DOTGiverComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

