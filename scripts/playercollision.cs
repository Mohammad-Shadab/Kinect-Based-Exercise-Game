
using UnityEngine;

public class playercollision : MonoBehaviour    // Responsible to detect the losing conddtion of game.
{

    
    void OnCollisionEnter( Collision collisioninfo)  //Called automatically when an obstacle hits the player
    { 
        if(collisioninfo.collider.tag == "obstacle")    
        {
            FindObjectOfType<gamemanager>().endgame();
        }

    }
   

   
}
