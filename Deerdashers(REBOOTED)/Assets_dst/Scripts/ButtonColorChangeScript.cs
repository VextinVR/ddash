using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonColorChangeScript : MonoBehaviour
{

    public GameObject Button;
    public Material buttonPressed;
    public Material buttonUnPressed;

    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Button.GetComponent<MeshRenderer>().material = buttonPressed;
    }

    // Update is called once per frame
    void OnTriggerExit()
    {
        Button.GetComponent<MeshRenderer>().material = buttonUnPressed;
    }
}
