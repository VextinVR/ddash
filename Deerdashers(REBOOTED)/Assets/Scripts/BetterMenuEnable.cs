using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using easyInputs;

public class BetterMenuEnable : MonoBehaviour
{
    public EasyHand LeftHand;
    public GameObject ModMenuGroup;
    public GameObject ModMenu;
    private bool IsEnabled;
    private bool enable = false;
    private float counter;
    private void Update()
    {
        if (ModMenuGroup.activeInHierarchy)
        {
            if (EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand) && IsEnabled == false)
            {
                
                    
                    IsEnabled = true;
                    ModMenu.SetActive(true);
                
            }
            else if (EasyInputs.GetThumbStickButtonDown(EasyHand.LeftHand) && IsEnabled == true)
            {
                IsEnabled = false;
                ModMenu.SetActive(false);
            }
        }
    }
}