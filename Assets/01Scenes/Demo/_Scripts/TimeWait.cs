using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeWait : MonoBehaviour
{

    public Text ScoreText;
    private int CurrentTime = 0;

    // Use this for initialization
    void Start()
    {
        LoopTime();
    }

    // Update is called once per frame
    void Update()
    {

    }


    int minutes = 0;
    int seconds = 0;
    public void OnSetTime(int curTime)
    {
        seconds = curTime % 60;
        minutes = curTime / 60;
        if (minutes >= 99)
            minutes = 99;

        ScoreText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }


    private void LoopTime()
    {
        // if (CurrentStatus == GameStatus.Normal)
        // {
        // LeanTween.value(0, 1, 1f).setOnComplete(s =>
        // {
        CurrentTime += 1;
        OnSetTime(CurrentTime);

        LoopTime();
        // });
        // }
    }
}
