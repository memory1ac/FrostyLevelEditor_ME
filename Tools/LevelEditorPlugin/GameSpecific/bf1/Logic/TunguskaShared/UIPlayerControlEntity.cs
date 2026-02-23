namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIPlayerControlEntityData))]
public class UIPlayerControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIPlayerControlEntityData>
{
    public new FrostySdk.Ebx.UIPlayerControlEntityData Data => data as FrostySdk.Ebx.UIPlayerControlEntityData;
    public override string DisplayName => "UIPlayerControl";

    public UIPlayerControlEntity(FrostySdk.Ebx.UIPlayerControlEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

