using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CompletionScreen : MonoBehaviour {

    public Text HighScore;
    public Text BestTime;
    public Text currentScore;
    public Text Totaltime;

    public int HighestScore, CurrentScore, BestTimeMin, BestTimeSec, CurrentTimeMin, CurrentTimeSec;


    // Use this for initialization
    void Start () {
        HighestScore = PlayerPrefs.GetInt("HighScore");
        CurrentScore = PlayerPrefs.GetInt("CurrentScore");
        BestTimeMin = PlayerPrefs.GetInt("BestMinTime");
        BestTimeSec = PlayerPrefs.GetInt("BestSecTime");
        CurrentTimeMin = PlayerPrefs.GetInt("MinTime");
        CurrentTimeSec = PlayerPrefs.GetInt("SecTime");
    }
	
	// Update is called once per frame
	void Update () {
        Totaltime.text = "Total Time: " + CurrentTimeMin.ToString("00") + ":" + CurrentTimeSec.ToString("00");
        BestTime.text = "Best Time: " + BestTimeMin.ToString("00") + ":" + BestTimeSec.ToString("00");
        HighScore.text = "Highest Score : " + HighestScore.ToString();
        currentScore.text = "Score : " + CurrentScore.ToString();
    }
}
