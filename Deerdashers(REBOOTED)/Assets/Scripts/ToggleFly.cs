using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GorillaLocomotion;
using easyInputs;
public class ToggleFly : MonoBehaviour
{
    public bool IsOn = false;
    public Fly script;
    private void OnTriggerEnter(Collider other)
    {
        if (script.Ison == false)
        {
            script.Ison = true;
        }
        else if(script.Ison == true)
        {
            script.Ison = false;
        }
    }
}
