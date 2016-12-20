using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public int count;
    public Text countText;
    public Text clearLevelText;
    public Text totalTimeText;
    public Text currentTimeText;

    public float sec, min, currentSec, currentMin;
    private float startingSec, startingMin;
    private Scene currentScene;

	public int totalPickups;

    // Use this for initialization
    void Start () {
        currentScene = SceneManager.GetActiveScene();

        count = PlayerPrefs.GetInt("CurrentScore");
        setCountText();
        clearLevelText.gameObject.SetActive(false);
 
		startingSec = PlayerPrefs.GetInt("SecTime");
		startingMin = PlayerPrefs.GetInt("MinTime");
    }

	// Update is called once per frame
	void Update () {
        setTotalTimeText();
        setTimeText();
	}

    IEnumerator OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag ("pickUps")) {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		} else if (other.gameObject.CompareTag ("goal")) {
			PlayerPrefs.SetInt ("SecTime", (int)sec);
			PlayerPrefs.SetInt ("MinTime", (int)min);
			PlayerPrefs.SetInt ("CurrentScore", count);
			clearLevelText.gameObject.SetActive (true);
			float fadeTime = GameObject.Find ("Stage").GetComponent<Fading> ().BeginFade (1);
			yield return new WaitForSeconds (fadeTime);
			SceneManager.LoadScene (currentScene.buildIndex + 1);
		}

        else if (other.gameObject.CompareTag("deadZone"))
        {
            reset();
        }
    }

    void setTotalTimeText()
    {
		min = (int)(Time.timeSinceLevelLoad / 60) + startingMin;
		sec = (int)((Time.timeSinceLevelLoad + startingSec) % 60);
        totalTimeText.text = "Total Time : " + min.ToString("00") + ":" + sec.ToString("00");
    }
    void setTimeText()
    {
        currentMin = (int)(Time.timeSinceLevelLoad / 60);
        currentSec = (int)(Time.timeSinceLevelLoad % 60);
        currentTimeText.text = currentMin.ToString("00") + ":" + currentSec.ToString("00");
    }
        void setCountText()
    {
        countText.text = "Score : " + count.ToString();
    }

    void reset()
    {
        PlayerPrefs.SetInt("SecTime", (int)sec);
        PlayerPrefs.SetInt("MinTime", (int)min);
        SceneManager.LoadScene(currentScene.name);
    }
}
