using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon.VR;
using Photon;
using easyInputs;
using UnityEngine.XR;
using System.Linq;

public class ToggleGhostApe : MonoBehaviour
{
    public bool IsOn = false;

    public bool toggle;

    private bool enable = false;

    public GhostApeManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if (manager.IsOn == false)
        {
            manager.IsOn = true;
        }
        else
        {
            manager.IsOn = false;
        }
    }
}
