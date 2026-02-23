
namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SupplySphereComponentData))]
public class SupplySphereComponent : GameComponent, IEntityData<FrostySdk.Ebx.SupplySphereComponentData>
{
    public new FrostySdk.Ebx.SupplySphereComponentData Data => data as FrostySdk.Ebx.SupplySphereComponentData;
    public override string DisplayName => "SupplySphereComponent";

    public SupplySphereComponent(FrostySdk.Ebx.SupplySphereComponentData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

