using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

public class platforms : MonoBehaviour
{
    public XRNode xrNode = XRNode.LeftHand;
    private List<InputDevice> devices = new List<InputDevice>();
    private InputDevice device;

    public bool IsOn;
    public bool Grip;
    public Transform RightPlatFormSpawn;
    public Transform LeftPlatFormSpawn;
    public GameObject RightPlatForm;
    public GameObject LeftPlatForm;

    private float counter = 10f;
    private bool playedOnce = false;

    void GetDevice()
    {
        InputDevices.GetDevicesAtXRNode(xrNode, devices);
        device = devices.FirstOrDefault();
    }

    private void OnEnable()
    {
        if (!device.isValid)
            GetDevice();
    }

    void Update()
    {

        if (!device.isValid)
        {
            GetDevice();
        }

        bool gripButtonAction = false;

        if ((device.TryGetFeatureValue(CommonUsages.gripButton, out gripButtonAction) && gripButtonAction) && IsOn == true || Grip)
        {
            if (counter == 0)
            {
                counter = 5;

                if (xrNode == XRNode.LeftHand)
                {
                    if (playedOnce == false)
                    {
                        LeftPlatForm.transform.position = LeftPlatFormSpawn.position;
                        LeftPlatForm.SetActive(true);
                        playedOnce = true;
                    }
                }
                else
                {
                    playedOnce = false;
                }

                if (xrNode == XRNode.RightHand)
                {
                    if (playedOnce == false)
                    {
                        RightPlatForm.transform.position = RightPlatFormSpawn.position;
                        RightPlatForm.SetActive(true);
                        playedOnce = true;
                    }
                }
                else
                {
                    playedOnce = false;
                }
            }
        }
        else if (counter > 0)
        {
            counter -= 1;
        }


        else


        {
            if (xrNode == XRNode.LeftHand)
            {
                LeftPlatForm.SetActive(false);
            }

            if (xrNode == XRNode.RightHand)
            {
                RightPlatForm.SetActive(false);
            }
        }
    }
}