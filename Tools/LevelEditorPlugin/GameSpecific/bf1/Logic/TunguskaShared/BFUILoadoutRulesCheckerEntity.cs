namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUILoadoutRulesCheckerEntityData))]
public class BFUILoadoutRulesCheckerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUILoadoutRulesCheckerEntityData>
{
    public new FrostySdk.Ebx.BFUILoadoutRulesCheckerEntityData Data => data as FrostySdk.Ebx.BFUILoadoutRulesCheckerEntityData;
    public override string DisplayName => "BFUILoadoutRulesChecker";

    public BFUILoadoutRulesCheckerEntity(FrostySdk.Ebx.BFUILoadoutRulesCheckerEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

