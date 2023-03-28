using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using UnityEngine.XR;

public class ReportingOnLeaderBoard : MonoBehaviour
{
    public TextMeshPro playerUsername;

    public LeaderBoardWithReporting script;


    [Header("START AT 0")]
    public int playerSpot;

    public bool reporting;


    public bool HateSpeach;
    public bool Toxic;
    public bool Cheating;


    string webhook_link = "https://discord.com/api/webhooks/1073024925528502282/R9jeO8Q4c1J65Deqry-MZRi4SM66YoUxbSkhSp0D7KRgpbJDIWBS9zz-OJLQ5hTOWq25";
    private void OnTriggerEnter(Collider other)
    {
        base.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
        if (reporting)
        {
            script.activereportperson = script.usernames[playerSpot];

            if (Toxic)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Toxic" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Toxic" + "     ");
                    }));
                }
            }
            if (HateSpeach)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "HateSpeach" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "HateSpeach" + "     ");
                    }));
                }
            }
            if (Cheating)
            {
                if (script.activereportperson == "")
                {

                }
                else
                {
                    StartCoroutine(SendWebhook(webhook_link, "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Cheating" + "     ", (success) =>
                    {
                        if (success)
                            Debug.Log("Sent = " + "**Reporter: **" + playerUsername.text + " | " + "**Offender Username: **" + script.activereportperson + " | " + "**Reason: **" + "Cheating" + "     ");
                    }));
                }
            }
        }
    }

    IEnumerator SendWebhook(string link, string message, System.Action<bool> action)
    {
        WWWForm form = new WWWForm();
        form.AddField("content", message);
        using (UnityWebRequest www = UnityWebRequest.Post(link, form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
                action(false);
            }
            else
                action(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        base.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
    }
}
