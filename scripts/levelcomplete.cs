
using UnityEngine;
using UnityEngine.SceneManagement;
public class levelcomplete : MonoBehaviour
{
    public void loadnextlevel()  //Loads next level after current level is completed.

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //loads next level 
    }

    public void loadmainmenu() //Loads mainmenu after gameover UI
    {
        SceneManager.LoadScene("gamestart"); 
    }
}
