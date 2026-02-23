namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFSpectatorPlayerHighlightEntityData))]
public class BFSpectatorPlayerHighlightEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFSpectatorPlayerHighlightEntityData>
{
    public new FrostySdk.Ebx.BFSpectatorPlayerHighlightEntityData Data => data as FrostySdk.Ebx.BFSpectatorPlayerHighlightEntityData;
    public override string DisplayName => "BFSpectatorPlayerHighlight";

    public BFSpectatorPlayerHighlightEntity(FrostySdk.Ebx.BFSpectatorPlayerHighlightEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

