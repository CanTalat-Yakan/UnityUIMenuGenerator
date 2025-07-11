using UnityEngine;

namespace UnityEssentials
{
    public class UIMenuColorSliderData : UIMenuGeneratorTypeTemplate
    {
        [Space]
        public Gradient Gradient;
        [Space]
        [Range(0, 100)]
        public float Default;

        public override object GetDefault() => Default;
    }
}