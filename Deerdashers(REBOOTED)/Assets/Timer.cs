using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float duration = 10f; // duration of the timer in seconds
    private float timeLeft; // time left on the timer
    private TMP_Text timerText; // reference to the UI text component to display the timer

    private void Start()
    {
        timeLeft = duration;
        timerText = GetComponent<TMP_Text>(); // get the TMP_Text component from the same game object
    }

    private void Update()
    {
        timeLeft -= Time.deltaTime; // decrement the time left by the time passed since the last frame

        if (timeLeft <= 0f)
        {
            Debug.Log("Time's up!");
            // add any other actions you want to perform when the timer ends
            enabled = false; // disable the script to stop the timer from running
            return; // exit the method early if the timer has expired
        }

        // update the timer text every second
        if (Mathf.FloorToInt(timeLeft) != Mathf.FloorToInt(timeLeft + Time.deltaTime))
        {
            // convert timeLeft to minutes and seconds
            int minutes = Mathf.FloorToInt(timeLeft / 60);
            int seconds = Mathf.FloorToInt(timeLeft % 60);

            // format the timer text
            string timerString = string.Format("{0:0}:{1:00}", minutes, seconds);

            // update the timer text on the UI
            timerText.text = timerString;
        }
    }
}
