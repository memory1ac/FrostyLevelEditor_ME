namespace LevelEditorPlugin.Entities;

[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBreakthroughEorSectorsWidgetData))]
public class UIBreakthroughEorSectorsWidget : UIShapeBase, IEntityData<FrostySdk.Ebx.UIBreakthroughEorSectorsWidgetData>
{
    public new FrostySdk.Ebx.UIBreakthroughEorSectorsWidgetData Data => data as FrostySdk.Ebx.UIBreakthroughEorSectorsWidgetData;
    public override string DisplayName => "UIBreakthroughEorSectorsWidget";

    public UIBreakthroughEorSectorsWidget(FrostySdk.Ebx.UIBreakthroughEorSectorsWidgetData inData, Entity inParent)
        : base(inData, inParent)
    {
    }
}

