namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.TokenCountModifierEntityData))]
public class TokenCountModifierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TokenCountModifierEntityData>
{
    public new FrostySdk.Ebx.TokenCountModifierEntityData Data => data as FrostySdk.Ebx.TokenCountModifierEntityData;
    public override string DisplayName => "TokenCountModifier";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public TokenCountModifierEntity(FrostySdk.Ebx.TokenCountModifierEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

