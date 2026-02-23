namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIIngameMenuEntityData))]
public class UIIngameMenuEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIIngameMenuEntityData>
{
    public new FrostySdk.Ebx.UIIngameMenuEntityData Data => data as FrostySdk.Ebx.UIIngameMenuEntityData;
    public override string DisplayName => "UIIngameMenu";

    public UIIngameMenuEntity(FrostySdk.Ebx.UIIngameMenuEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

