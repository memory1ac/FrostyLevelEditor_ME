namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevolutionMessageEntityData))]
public class LevolutionMessageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LevolutionMessageEntityData>
{
    public new FrostySdk.Ebx.LevolutionMessageEntityData Data => data as FrostySdk.Ebx.LevolutionMessageEntityData;
    public override string DisplayName => "LevolutionMessage";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public LevolutionMessageEntity(FrostySdk.Ebx.LevolutionMessageEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

