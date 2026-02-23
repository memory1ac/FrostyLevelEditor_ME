namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.SelectedCharacterProxyData))]
public class SelectedCharacterProxy : CharacterProxy, IEntityData<FrostySdk.Ebx.SelectedCharacterProxyData>
{
    public new FrostySdk.Ebx.SelectedCharacterProxyData Data => data as FrostySdk.Ebx.SelectedCharacterProxyData;

    public SelectedCharacterProxy(FrostySdk.Ebx.SelectedCharacterProxyData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

