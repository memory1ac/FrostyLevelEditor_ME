namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.FirstPartyUIEntityData))]
public class FirstPartyUIEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FirstPartyUIEntityData>
{
    public new FrostySdk.Ebx.FirstPartyUIEntityData Data => data as FrostySdk.Ebx.FirstPartyUIEntityData;
    public override string DisplayName => "FirstPartyUI";

    public FirstPartyUIEntity(FrostySdk.Ebx.FirstPartyUIEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

