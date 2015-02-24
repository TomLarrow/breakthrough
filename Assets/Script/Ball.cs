using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{ 
    void OnCollisionEnter(Collision collision)
    {
        
        // Start with Gravity off so that the ball just hovers there until the player hits it the first time.
        if (collision.collider.tag == "Player")
        {
            rigidbody.useGravity = true;
        }

        if (collision.collider.tag == "Brick")
        {
            Destroy(collision.collider.gameObject);
        }
    }
}
