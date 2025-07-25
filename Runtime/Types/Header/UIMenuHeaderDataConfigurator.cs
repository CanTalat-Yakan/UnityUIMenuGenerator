using UnityEngine;

namespace UnityEssentials
{
    public class UIMenuHeaderDataConfigurator : UIMenuTypeDataConfiguratorBase<UIMenuHeaderData>
    {
        [Space]
        public int MarginTop = 20;
        public string Title = string.Empty;

        public override void ApplyDynamicConfiguration()
        {
            Data.MarginTop = MarginTop;
            Data.Name = Title;
        }
    }
}
