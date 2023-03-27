using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour
{
    public float timer;
    public float endTime;
    [Space]
    public Color startColor;
    public Color endTimeColor;
    [Space]
    public UnityEvent OnEnd;

    [Header("REFERENCES")]

    public TextMeshProUGUI text;
    

    private float currentTime;
    bool play;

    private void Start()
    {
        currentTime = timer;
        StartCountdown();
        text.color = startColor;
    }

    public void StartCountdown()
    {
        play = true;
    }

    public void StopCountdown()
    {
        play = false;
    }

    private void Update()
    {
        if (!play) return; // FILTER

        // Core
        currentTime -= Time.deltaTime;
        string toDisplay;

        if(currentTime > endTime)
        {
            toDisplay = string.Format("{0:0}", currentTime);
        }
        else
        {
            text.color = endTimeColor;
           
            toDisplay = string.Format("{0:0.0}", currentTime);
        }

        text.text = toDisplay;

        //End
        if (currentTime <= 0)
        {
            currentTime = 0;
            text.text = "0";
            StopCountdown();
            OnEnd.Invoke();
            SceneManager.LoadScene(1);
        }
    }
}
