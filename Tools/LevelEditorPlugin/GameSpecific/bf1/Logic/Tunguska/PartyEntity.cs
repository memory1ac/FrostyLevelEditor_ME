namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.PartyEntityData))]
public class PartyEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PartyEntityData>
{
    public new FrostySdk.Ebx.PartyEntityData Data => data as FrostySdk.Ebx.PartyEntityData;
    public override string DisplayName => "Party";

    public PartyEntity(FrostySdk.Ebx.PartyEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

