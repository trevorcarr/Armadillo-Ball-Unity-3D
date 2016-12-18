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

	public void ExitGame()
	{
		Application.Quit ();
	}
/*
	public void MainMenu()
	{
		SceneManager.LoadScene ();
	}

	public void HowToPlay()
	{
		SceneManager.LoadScene ();
	}

	public void Credits()
	{
		SceneManager.LoadScene ();
	}

	public void Play()
	{
		SceneManager.LoadScene ();
	}

	public void AdventureMode()
	{
		SceneManager.LoadScene ();
	}

	public void TimeTrial()
	{
		SceneManager.LoadScene ();
	}

	public void LevelSelect()
	{
		SceneManager.LoadScene ();
	}
*/

}
