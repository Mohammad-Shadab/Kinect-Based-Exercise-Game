
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public Text scoretext;
    public Transform lastobject;
    // Update is called once per frame
    void Update()                                   //Keeps updating the score of player by tracking the position of last obstacle
    {
        //Debug.Log(player.position.z);
        scoretext.text = ((lastobject.position.z-411)*-1).ToString("0") ;

    }
}
