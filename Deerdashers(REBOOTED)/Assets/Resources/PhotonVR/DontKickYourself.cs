using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class DontKickYourself : MonoBehaviour
{
    public PhotonView ptView;
    public Collider collider;

    void Update()
    {
        if (ptView.IsMine)
        {
            collider.enabled = false;
        }
        else
        {
            collider.enabled = true;
        }

    }
}