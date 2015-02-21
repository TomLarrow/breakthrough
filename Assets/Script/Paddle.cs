using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{

    void FixedUpdate() 
    {
        // Set the position of the paddle to match the ScreenToWorldPoint of the mouse   
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        //Debug.Log(mousePos);
        rigidbody.MovePosition(mousePos);
	}
}
