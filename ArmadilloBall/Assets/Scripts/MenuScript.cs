using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	public void NewGame()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        PlayerPrefs.SetInt("SecTime", 0);
        PlayerPrefs.SetInt("MinTime", 0);
        SceneManager.LoadScene(1);
    }
}
