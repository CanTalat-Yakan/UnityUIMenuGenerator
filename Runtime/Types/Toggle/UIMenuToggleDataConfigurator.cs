using UnityEngine;

namespace UnityEssentials
{
    public class UIMenuToggleDataConfigurator : UIMenuTypeDataConfiguratorBase<UIMenuToggleData>
    {
        [Space]
        public bool Default;

        public override void ApplyDynamicConfiguration() =>
            Data.Default = Default;
    }
}
