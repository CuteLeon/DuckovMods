using UnityEngine;

namespace DevToolMod
{
    public class ModBehaviour : Duckov.Modding.ModBehaviour
    {
        protected override void OnAfterSetup()
        {
            Debug.Log("DevToolMod OnAfterSetup.");
            base.OnAfterSetup();
        }

        protected override void OnBeforeDeactivate()
        {
            Debug.Log("DevToolMod OnBeforeDeactivate.");
            base.OnBeforeDeactivate();
        }
    }
}
