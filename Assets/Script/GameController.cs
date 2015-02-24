using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    [SerializeField]
    private GameObject brick;

    [SerializeField]
    private GameObject ball;

    [SerializeField]
    private float ballXPosition;

    [SerializeField]
    private float ballYPosition;

    [SerializeField]
    private float brickXPosition;

    [SerializeField]
    private float brickYPosition;

    [SerializeField]
    private int numBricks;

    [SerializeField]
    private int numColumns;

    [SerializeField]
    private float verticalDistance;

    [SerializeField]
    private float horizontalDistance;

	// Use this for initialization
	void Start () 
    {
        for (int i = 0; i < numColumns; i++)
        {
            SpawnBlockColumn(brickXPosition - (i * horizontalDistance), brickYPosition + ( 1.5f * i * verticalDistance));
        }

        SpawnBall(ballXPosition, ballYPosition);
	}
	
    // Spawn a row of blocks
    void SpawnBlockColumn (float _xPos, float _yPos)
    {
        for (int i = 0; i < numBricks; i++)
        {
            Instantiate(brick, new Vector3(_xPos, _yPos + (i * verticalDistance), 0), Quaternion.identity);
        }
    }

    // Spawn the ball
    void SpawnBall (float _xPos, float _yPos)
    {
        Instantiate(ball, new Vector3(_xPos, _yPos, 0), Quaternion.identity);
    }
}
