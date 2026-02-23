namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIConsoleKeyboardEntityData))]
public class UIConsoleKeyboardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIConsoleKeyboardEntityData>
{
    public new FrostySdk.Ebx.UIConsoleKeyboardEntityData Data => data as FrostySdk.Ebx.UIConsoleKeyboardEntityData;
    public override string DisplayName => "UIConsoleKeyboard";
    public override FrostySdk.Ebx.Realm Realm => Data.Realm;

    public UIConsoleKeyboardEntity(FrostySdk.Ebx.UIConsoleKeyboardEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

