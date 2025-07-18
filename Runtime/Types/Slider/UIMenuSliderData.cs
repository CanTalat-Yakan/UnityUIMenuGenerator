using UnityEngine;

namespace UnityEssentials
{
    public class UIMenuSliderData : UIMenuTypeDataBase
    {
        [Space]
        public bool IsFloat;
        public float MinRange = 0;
        public float MaxRange = 100;

        [Space]
        public float Default;

        public override object GetDefault() => Mathf.Clamp(Default, MinRange, MaxRange);

        public override void ApplyDynamicReset()
        {
            IsFloat = false;
            MinRange = 0;
            MaxRange = 100;
            Default = 0;
        }
    }
}