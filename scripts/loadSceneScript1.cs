
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadSceneScript1 : MonoBehaviour
{

    public static bool gameispaused = false;
    public GameObject menuUI;     //container of UI


    public void newgame()  //Loads level 1 of the game when called.
    {
        SceneManager.LoadScene("level1");
    }

    public void options()  //Loads the options screen when called.
    {
        menuUI.SetActive(true);
    }

    public void quit()  // Quits the game when called.
    {
        Application.Quit();
    }


    public void mainmenu() //Loads the mainmenu when called.
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("gamestart");
    }


   

    public void PauseGame()  //Pauses the game by setting timescale = 0 and activating Pause Panel.
    {
        Time.timeScale = 0f;
        menuUI.SetActive(true);
        gameispaused = true;

        // SceneManager.LoadScene("gamepaused");
    }

    public void ResumeGame()  //Resumes the game by setting timescale = 1 and deactivating Pause Panel.
    {
        Time.timeScale = 1;
        menuUI.SetActive(false);
        gameispaused = false;
       // SceneManager.LoadScene("level1");

    }

    public void Update() //function to keep track whether ESC (pause) is pressed or not.
    {
        if (Input.GetKeyDown("escape"))
        {
            if (gameispaused)
            {
                ResumeGame();
            }

            else
            {
                PauseGame();
            }
        }
    }

}
