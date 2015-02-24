using UnityEngine;
using System.Collections;

public class BallMissed : MonoBehaviour 
{

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Ball")
        {
            Destroy(collider.gameObject);
            GameController.NewBall();
        }
    }
}
