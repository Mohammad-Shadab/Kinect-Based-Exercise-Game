using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsmovement : MonoBehaviour
{
    public Rigidbody rb;
    public float backforce = 2000f;
    // Update is called once per frame
    void FixedUpdate()                     // Responsible for motion of obstacles, providess force
    {
        rb.AddForce(0, 0, - backforce* Time.deltaTime);
    }
}
