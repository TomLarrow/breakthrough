using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            rigidbody.useGravity = true;
        }
    }

}
