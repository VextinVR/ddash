using Oculus.Platform;
using Oculus.Platform.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class PurchaseTwigsScript : MonoBehaviour
{
    public GameObject button;
    public int Ammount;
    public string Sku;

    void OnTriggerEnter()
    {
        IAP.LaunchCheckoutFlow(Sku).OnComplete(PurchasedCallBack);
    }

    private void PurchasedCallBack(Message<Oculus.Platform.Models.Purchase> msg)
    {
        if (msg.IsError) return;
        int s = PlayerPrefs.GetInt("coins");
        PlayerPrefs.SetInt("coins", PlayerPrefs.GetInt("coins") + Ammount);


    }
}


