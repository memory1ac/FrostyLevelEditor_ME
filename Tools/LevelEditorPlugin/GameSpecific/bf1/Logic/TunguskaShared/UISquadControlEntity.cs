namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UISquadControlEntityData))]
public class UISquadControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UISquadControlEntityData>
{
    public new FrostySdk.Ebx.UISquadControlEntityData Data => data as FrostySdk.Ebx.UISquadControlEntityData;
    public override string DisplayName => "UISquadControl";

    public UISquadControlEntity(FrostySdk.Ebx.UISquadControlEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

