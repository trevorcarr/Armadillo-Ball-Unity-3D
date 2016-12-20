using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0); //loads main menu
    }

    public void GameModeSelect()
    {
        SceneManager.LoadScene(1); //loads game mode select
    }

    public void AdventureMode()
    {
        resetPrefs();
        PlayerPrefs.SetInt("GameMode", 0);
        SceneManager.LoadScene(3); //loads level 1, for now
    }

    public void TimeTrialLevelSelect()
    {
        PlayerPrefs.SetInt("GameMode", 1);
        SceneManager.LoadScene(2); //loads level select
    }

    public void Level1()
    {
        resetPrefs();
        SceneManager.LoadScene(3); //loads level 1
    }

    public void Level2()
    {
        resetPrefs();
        SceneManager.LoadScene(4); //loads level 2
    }

    public void Level3()
    {
        resetPrefs();
        SceneManager.LoadScene(5); //loads level 3
    }

    public void Level4()
    {
        resetPrefs();
        SceneManager.LoadScene(6); //loads level 4
    }

    public void Level5()
    {
        resetPrefs();
        SceneManager.LoadScene(7); //loads level 5
    }

    public void Level6()
    {
        resetPrefs();
        SceneManager.LoadScene(8); //loads level 6
    }

    public void Level7()
    {
        resetPrefs();
        SceneManager.LoadScene(9); //loads level 7
    }
    /*
        public void Level8()
        {
            resetPrefs();
            SceneManager.LoadScene (10); //loads level 8
        }

        public void Level9()
        {
            resetPrefs();
            SceneManager.LoadScene (11); //loads level 9
        }

        public void Level10()
        {
            resetPrefs();
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

    public void resetPrefs()
    {
        PlayerPrefs.SetInt("CurrentScore", 0);
        PlayerPrefs.SetInt("SecTime", 0);
        PlayerPrefs.SetInt("MinTime", 0);
        SceneManager.LoadScene(1);
    }
}
