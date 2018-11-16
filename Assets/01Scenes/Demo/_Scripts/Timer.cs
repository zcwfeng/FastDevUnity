

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text ScoreText;
    public float TotalTime;//倒计时总时间
    public float RateTime;//倒计时速率
    public float TargetTime;//倒计时的目标时间
    private float CurrentTime;//当前倒计时剩余时间


    private Text ShowTime;
    public bool IsRepeat = false;//是否循环倒计时



    // Use this for initialization
    void Start()
    {
        CurrentTime = TotalTime;
        ShowTime = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {



        CurrentTime -= RateTime * Time.deltaTime;
        if (CurrentTime < TargetTime)
        {
            ScoreText.text = "倒计时结束";
            if (IsRepeat)//循环倒计时
            {
                CurrentTime = TotalTime;
            }
        }
        else
            // ShowTime.text = CurrentTime.ToString("F2");//显示倒计时时间
            ScoreText.text = CurrentTime.ToString("F2");
    }
}
