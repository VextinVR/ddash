using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class PlayersOnline : MonoBehaviour
{
    public string Count;
    public TextMeshPro Text;
    private void Update()
    {

        Count = PhotonNetwork.CountOfPlayers.ToString();
        Text.text = "Current Players Online: " + Count;
    }
}
