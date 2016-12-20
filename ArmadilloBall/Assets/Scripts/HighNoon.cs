using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighNoon : MonoBehaviour {

    public Text highScoreText;
    public Text bestTimeText;
    public int sec, min, count;

    void Start()
    {
        min = PlayerPrefs.GetInt("BestMinTime");
        sec = PlayerPrefs.GetInt("BestSecTime");
        count = PlayerPrefs.GetInt("HighScore");
    }
    void Update()
    {
        bestTimeText.text = "Best Time : " + min.ToString("00") + ":" + sec.ToString("00");
        highScoreText.text = "Score : " + count.ToString();
    }
}
