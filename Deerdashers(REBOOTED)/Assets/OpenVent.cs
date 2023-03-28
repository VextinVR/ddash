using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenVent : MonoBehaviour
{
    public GameObject vent;

    public void OnTriggerEnter(Collider other)
    {
        vent.SetActive(false);
    }
}
