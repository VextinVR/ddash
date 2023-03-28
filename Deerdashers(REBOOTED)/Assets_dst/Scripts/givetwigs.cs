using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class givetwigs : MonoBehaviour
{
    // Start is called before the first frame update
    public int price;

    private void OnTriggerEnter(Collider other)
    {

        int s = PlayerPrefs.GetInt("coins");

        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + price);

    }

}



