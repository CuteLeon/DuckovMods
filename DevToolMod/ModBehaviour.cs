using Duckov.UI;
using UnityEngine;

namespace DevToolMod
{
    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        protected override void OnAfterSetup()
        {
            Debug.Log("DevToolMod OnAfterSetup.");
            InventoryView.OnActiveViewChanged += this.InventoryView_OnActiveViewChanged;
            ItemHoveringUI.onSetupItem += this.ItemHoveringUI_onSetupItem;
            base.OnAfterSetup();
        }

        private void ItemHoveringUI_onSetupItem(ItemHoveringUI arg1, ItemStatsSystem.Item arg2)
        {
        }

        private void InventoryView_OnActiveViewChanged()
        {
        }

        protected override void OnBeforeDeactivate()
        {
            Debug.Log("DevToolMod OnBeforeDeactivate.");
            base.OnBeforeDeactivate();
        }
    }
}
