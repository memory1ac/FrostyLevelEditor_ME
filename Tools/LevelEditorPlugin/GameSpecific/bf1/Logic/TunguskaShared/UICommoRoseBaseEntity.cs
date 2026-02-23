namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICommoRoseBaseEntityData))]
public class UICommoRoseBaseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICommoRoseBaseEntityData>
{
    public new FrostySdk.Ebx.UICommoRoseBaseEntityData Data => data as FrostySdk.Ebx.UICommoRoseBaseEntityData;
    public override string DisplayName => "UICommoRoseBase";

    public UICommoRoseBaseEntity(FrostySdk.Ebx.UICommoRoseBaseEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

