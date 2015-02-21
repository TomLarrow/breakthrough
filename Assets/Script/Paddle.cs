using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
    public float rotateSpeed;

    void FixedUpdate() 
    {
        // Set the position of the paddle to match the ScreenToWorldPoint of the mouse   
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        //Debug.Log(mousePos);
        rigidbody.MovePosition(mousePos);

        
        // Rotate the paddle with the mousewheel  I'm not sure this is the best way of doing it, since it doesn't always zero back out.
        transform.Rotate(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * rotateSpeed * Time.deltaTime );

	}
}
