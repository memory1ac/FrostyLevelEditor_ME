namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.BFUIElementMinimapCombatAreaEntityData))]
public class BFUIElementMinimapCombatAreaEntity : BFUIElementEntity, IEntityData<FrostySdk.Ebx.BFUIElementMinimapCombatAreaEntityData>
{
    public new FrostySdk.Ebx.BFUIElementMinimapCombatAreaEntityData Data => data as FrostySdk.Ebx.BFUIElementMinimapCombatAreaEntityData;
    public override string DisplayName => "BFUIElementMinimapCombatArea";

    public BFUIElementMinimapCombatAreaEntity(FrostySdk.Ebx.BFUIElementMinimapCombatAreaEntityData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

