using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.VR;

public class OfflineRIg : MonoBehaviour
{

    public GameObject LeftHand;
    public GameObject RightHand;
    public GameObject Head;
    public PhotonVRManager Manager;
    public bool checkbox = true;

    void Update()
    {
        if (PhotonNetwork.InRoom == false || checkbox)
        {
            LeftHand.SetActive(true);
            RightHand.SetActive(true);
            Head.SetActive(true);
            LeftHand.transform.position = Manager.LeftHand.position;
            RightHand.transform.position = Manager.RightHand.position;
            LeftHand.transform.rotation = Manager.LeftHand.rotation;
            RightHand.transform.rotation = Manager.RightHand.rotation;
            Head.transform.position = Manager.Head.position;
            Head.transform.rotation = Manager.Head.rotation;

            // = new Color(5,0,5);
        }
        if (PhotonNetwork.InRoom && checkbox == false)
        {
            LeftHand.SetActive(false);
            RightHand.SetActive(false);
            Head.SetActive(false);

        }

    }
} 
