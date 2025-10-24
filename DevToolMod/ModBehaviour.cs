using Duckov.UI;
using Duckov.Utilities;
using ItemStatsSystem;
using TMPro;
using UnityEngine;

namespace DevToolMod
{
    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        TextMeshProUGUI text = null!;

        TextMeshProUGUI Text
        {
            get
            {
                if (this.text == null)
                {
                    this.text = Instantiate(GameplayDataSettings.UIStyle.TemplateTextUGUI);
                }
                return this.text;
            }
        }

        void Awake()
        {
            Debug.Log("DisplayItemValue Loaded!!!");
        }

        void OnDestroy()
        {
            if (this.text != null)
                Destroy(this.text);
        }

        void OnEnable()
        {
            Debug.Log("DisplayItemValue Enable!!!");
            ItemHoveringUI.onSetupItem += this.OnSetupItemHoveringUI;
            ItemHoveringUI.onSetupMeta += this.OnSetupMeta;
        }

        void OnDisable()
        {
            Debug.Log("DisplayItemValue Disable!!!");
            ItemHoveringUI.onSetupItem -= this.OnSetupItemHoveringUI;
            ItemHoveringUI.onSetupMeta -= this.OnSetupMeta;
        }

        private void OnSetupMeta(ItemHoveringUI uI, ItemMetaData data)
        {
            Debug.Log("DisplayItemValue SetupMeta!!!");
            this.Text.gameObject.SetActive(false);
        }

        private void OnSetupItemHoveringUI(ItemHoveringUI uiInstance, Item item)
        {
            Debug.Log("DisplayItemValue OnSetupItemHoveringUI!!!");
            if (item == null)
            {
                this.Text.gameObject.SetActive(false);
                return;
            }

            this.Text.gameObject.SetActive(true);
            this.Text.transform.SetParent(uiInstance.LayoutParent);
            this.Text.transform.localScale = Vector3.one;
            this.Text.text = $"${item.GetTotalRawValue() / 2}";
            this.Text.fontSize = 20f;
        }
    }
}
