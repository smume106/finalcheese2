 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timerText;
    private bool finish = false;

    // Start is called before the first frame update
    void Start()
    {
        TimingManager.myTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
            return;

        float t = Time.time - TimingManager.myTimer;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timerText.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finish = true;
    }
}
