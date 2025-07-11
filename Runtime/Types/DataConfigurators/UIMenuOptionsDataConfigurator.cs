using UnityEngine;

namespace UnityEssentials
{
    public class UIMenuOptionsDataConfigurator : MonoBehaviour
    {
        public string MenuName;
        public string Reference;

        [Space]
        public bool Reverse;
        public string[] Options;

        [Space]
        public int Default;

        private UIMenuOptionsData _optionsData;
        [HideInInspector] public UIMenuOptionsData OptionsData => _optionsData;

        public void Awake()
        {
            if (!UIMenu.Instances.TryGetValue(MenuName, out var menu))
                return;

            if (menu.Data?.GetDataByReference(Reference, out _optionsData) ?? false)
            {
                OptionsData.IsDynamic = true;
                OptionsData.Reverse = Reverse;
                OptionsData.Options = Options;
                OptionsData.Default = Default;
            }
        }
    }
}