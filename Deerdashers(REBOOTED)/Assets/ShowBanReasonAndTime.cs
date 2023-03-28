using System;
using UnityEngine;
using System.Collections.Generic;
using PlayFab;
using PlayFab.ClientModels;
using TMPro;

namespace Assets.Scripts
{
    public class ShowBanReasonAndTime : MonoBehaviour
    {
        public TextMeshPro BanReason;
        public TextMeshPro BanTime;

        void Start()
        {
            Login();
        }

        void Login()
        {
            var request = new LoginWithCustomIDRequest
            {
                CustomId = SystemInfo.deviceUniqueIdentifier,
                CreateAccount = true
            };
            PlayFabClientAPI.LoginWithCustomID(request, OnSuccess, OnError);
        }

        void OnSuccess(LoginResult result)
        {

        }

        void OnError(PlayFabError error)
        {
            Debug.Log("Error while logging in/creating account!");
            if (error.Error == PlayFabErrorCode.AccountBanned)
            {
                foreach (var item in error.ErrorDetails)
                {
                    BanTime.text = item.Key;
                    BanReason.text = item.Value[0];
                }
            }
        }

        void Update()
        {
            
        }
    }
}
