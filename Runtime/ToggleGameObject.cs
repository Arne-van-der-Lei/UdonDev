using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

public class ToggleGameObject : UdonSharpBehaviour
{
    public GameObject gameObject;
    public bool IsNetworked;

    public override void Interact()
    {
        if (IsNetworked)
        {
            SendCustomNetworkEvent(NetworkEventTarget.All, "GlobalInteract");
        }
        else
        {
            SendCustomEvent("GlobalInteract");
        }
    }

    public void GlobalInteract()
    {
        gameObject.SetActive(!gameObject.activeSelf);

    }
}
