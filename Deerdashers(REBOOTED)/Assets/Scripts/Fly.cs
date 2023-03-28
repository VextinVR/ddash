using UnityEngine;
using easyInputs;

public class Fly : MonoBehaviour
{
    public bool Ison = false;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public GameObject GorillaPlayer;
    public GameObject Camera;
    public bool triggerr;

    private Rigidbody rigidBody;

    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        //float horizontalInput = Input.GetAxis("Horizontal");
      //  float verticalInput = Input.GetAxis("Vertical");
        if (EasyInputs.GetPrimaryButtonDown(EasyHand.RightHand) && Ison == true || triggerr)
        {
            GorillaPlayer.GetComponent<Rigidbody>().velocity = Camera.transform.forward * speed;
        }
        else
        {

        }
    }
}
