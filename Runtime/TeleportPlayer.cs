
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleportPlayer : UdonSharpBehaviour
{
    public Transform PointToTpTo;

    public override void Interact()
    {
        Networking.LocalPlayer.TeleportTo(PointToTpTo.position, PointToTpTo.rotation);
    }
}
