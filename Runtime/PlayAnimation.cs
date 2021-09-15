
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PlayAnimation : UdonSharpBehaviour
{
    public Animator animator;
    public string AnimationToggleParameter;
    public bool IsNetworked;

    public override void Interact()
    {
        if (IsNetworked)
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, "InteractGlobal");
        }
        else
        {
            SendCustomEvent("InteractGlobal");
        }
            
    }

    public void InteractGlobal()
    {
        animator.SetBool(AnimationToggleParameter, !animator.GetBool(AnimationToggleParameter));
    }
}
