using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using easyInputs;
public class TogglePlatforms : MonoBehaviour
{
    public bool Isonn = false;
    public float Rpres;
    public float Lpres;
    public platforms Rplatforms;
    public platforms Lplatforms;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "RightHand Controller")
        {
            if (Isonn == false)
            {
                Isonn = true;
                Rplatforms.IsOn = true;
                Lplatforms.IsOn = true;
            }
            else
            {
                Isonn = false;
                Rplatforms.IsOn = false;
                Lplatforms.IsOn = false;
            }
        }
    }

    private void Update()
    {



        //float Rfloat = EasyInputs.GetGripButtonFloat(EasyHand.RightHand);
        //float Lfloat = EasyInputs.GetGripButtonFloat(EasyHand.LeftHand);

      //  Rpres = Rfloat;
        //Lpres = Lfloat;

       // if (Rfloat != 0)
       // {
      //      RightPlatForm.transform.position = RightPlatFormSpawn.position;
       //     RightPlatForm.SetActive(true);
      //  }

      //  if (Lfloat != 0)
      //  {
      //      LeftPlatForm.transform.position = LeftPlatFormSpawn.position;
      //      LeftPlatForm.SetActive(true);
      //  }

        /////////////////////////////////////////

      //  if (Rfloat == 0)
       // {
       //     RightPlatForm.SetActive(false);
      //  }
      //
       // if (Lfloat == 0)
       // {
       //     LeftPlatForm.SetActive(false);
      //  }
    }

}