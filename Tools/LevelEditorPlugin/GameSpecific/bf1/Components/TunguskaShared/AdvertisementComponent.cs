
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.AdvertisementComponentData))]
public class AdvertisementComponent : PartComponent, IEntityData<FrostySdk.Ebx.AdvertisementComponentData>
{
    public new FrostySdk.Ebx.AdvertisementComponentData Data => data as FrostySdk.Ebx.AdvertisementComponentData;
    public override string DisplayName => "AdvertisementComponent";

    public AdvertisementComponent(FrostySdk.Ebx.AdvertisementComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

