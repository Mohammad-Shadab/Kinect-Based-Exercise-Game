
using UnityEngine;

public class levelcompletecollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collisioninfo)
    {
        //Detects if last object has been dodged by the player hence game won and calls completelevel().

         if (collisioninfo.collider.tag == "obstacle") 
         {
            //Debug.Log("hit somethng");
             FindObjectOfType<gamemanager>().completelevel1();
        }
         
        

    }

}
