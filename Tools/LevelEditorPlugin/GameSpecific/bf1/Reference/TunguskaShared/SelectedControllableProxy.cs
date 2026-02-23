namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SelectedControllableProxyData))]
public class SelectedControllableProxy : BlueprintProxy, IEntityData<FrostySdk.Ebx.SelectedControllableProxyData>
{
    public new FrostySdk.Ebx.SelectedControllableProxyData Data => data as FrostySdk.Ebx.SelectedControllableProxyData;

    public SelectedControllableProxy(FrostySdk.Ebx.SelectedControllableProxyData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

