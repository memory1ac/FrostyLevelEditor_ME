namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUISoldierInfoEntityData))]
public class BFUISoldierInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BFUISoldierInfoEntityData>
{
    public new FrostySdk.Ebx.BFUISoldierInfoEntityData Data => data as FrostySdk.Ebx.BFUISoldierInfoEntityData;
    public override string DisplayName => "BFUISoldierInfo";

    public BFUISoldierInfoEntity(FrostySdk.Ebx.BFUISoldierInfoEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

