
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gamehasended = false; //flag to track if gamehas ended,to prevent multiple call of Game over
    public float restartDelay = 1f;
    public GameObject completelevelUI;
    public GameObject gameoverUI;

    //Activates LEVEL COMPLETE UI
    public void completelevel1()
    {
        //Debug.Log(" LEVEL WON");
        completelevelUI.SetActive(true);
    }


    //Activates GAME OVER UI.
    public void endgame()
    {
        if (gamehasended == false)
        {
            gamehasended = true;

            Debug.Log("GAME OVER");
            gameoverUI.SetActive(true);
            //Invoke("Restart", restartDelay);
        }
    }

    //void Restart()
    //{
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
     //   SceneManager.LoadScene("gamestart");
    //}


   


}
