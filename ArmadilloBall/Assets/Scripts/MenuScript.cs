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

	public void MainMenu()
	{
		SceneManager.LoadScene (0); //loads main menu
	}

	public void GameModeSelect()
	{
		SceneManager.LoadScene (1); //loads game mode select
	}

	public void AdventureMode()
	{
		SceneManager.LoadScene (3); //loads level 1, for now
	}
		
	public void TimeTrialLevelSelect()
	{
		SceneManager.LoadScene (2); //loads level select
	}

	public void Level1()
	{
		SceneManager.LoadScene (3); //loads level 1
	}

	public void Level2()
	{
		SceneManager.LoadScene (4); //loads level 2
	}

	public void Level3()
	{
		SceneManager.LoadScene (5); //loads level 3
	}

	public void Level4()
	{
		SceneManager.LoadScene (6); //loads level 4
	}

	public void Level5()
	{
		SceneManager.LoadScene (7); //loads level 5
	}

	public void Level6()
	{
		SceneManager.LoadScene (8); //loads level 6
	}

	public void Level7()
	{
		SceneManager.LoadScene (9); //loads level 7
	}
/*
	public void Level8()
	{
		SceneManager.LoadScene (10); //loads level 8
	}

	public void Level9()
	{
		SceneManager.LoadScene (11); //loads level 9
	}

	public void Level10()
	{
		SceneManager.LoadScene (12); //loads level 10
	}

	public void HowToPlay()
	{
		SceneManager.LoadScene ();
	}

	public void Credits()
	{
		SceneManager.LoadScene ();
	}
*/		

}
