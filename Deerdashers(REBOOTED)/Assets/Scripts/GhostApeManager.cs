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

public class GhostApeManager : MonoBehaviour
{
    public bool toggle;

    public bool IsOn;


    public Transform Head;
    public Transform LeftHand;
    public Transform RightHand;

    public Transform FHead;
    public Transform FLeftHand;
    public Transform FRightHand;

    public PhotonVRManager manager;
    void Start()
    {

    }

    public XRNode xrNode = XRNode.LeftHand;
    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice device;

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xrNode, devices);
        device = devices.FirstOrDefault();
    }

    // Update is called once per frame
    public void Update()
    {
        if (!device.isValid)
        {
            GetDevice();
        }

        bool gripButtonAction = false;

        if ((device.TryGetFeatureValue(CommonUsages.triggerButton, out gripButtonAction) && gripButtonAction) && IsOn || toggle)
        //if (EasyInputs.GetTriggerButtonDown(EasyHand.LeftHand) || toggle)
        {
            manager.Head = FHead;
            manager.LeftHand = FLeftHand;
            manager.RightHand = FRightHand;

        }
        else
        {
            FHead.position = Head.position;
            FHead.rotation = Head.rotation;

            FLeftHand.position = LeftHand.position;
            FLeftHand.rotation = LeftHand.rotation;

            FRightHand.position = RightHand.position;
            FRightHand.rotation = RightHand.rotation;

            manager.Head = Head;
            manager.LeftHand = LeftHand;
            manager.RightHand = RightHand;

        }

        // if ((device.TryGetFeatureValue(CommonUsages.triggerButton, out triggerButtonAction)) || toggle)
        // {
        //    enable = true;
        // }
        // else
        //  {
        //     enable = false;
        // }
    }
}
