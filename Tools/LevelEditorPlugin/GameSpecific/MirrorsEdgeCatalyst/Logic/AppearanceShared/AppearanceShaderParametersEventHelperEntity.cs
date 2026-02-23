using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AppearanceShaderParametersEventHelperEntityData))]
	public class AppearanceShaderParametersEventHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AppearanceShaderParametersEventHelperEntityData>
	{
		public new FrostySdk.Ebx.AppearanceShaderParametersEventHelperEntityData Data => data as FrostySdk.Ebx.AppearanceShaderParametersEventHelperEntityData;
		public override string DisplayName => "AppearanceShaderParametersEventHelper";

		public AppearanceShaderParametersEventHelperEntity(FrostySdk.Ebx.AppearanceShaderParametersEventHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

