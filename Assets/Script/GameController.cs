using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    [SerializeField]
    private GameObject brick;

    [SerializeField]
    private float xPosition;

    [SerializeField]
    private float yPosition;

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
            SpawnBlockColumn(xPosition - (i * horizontalDistance), yPosition + ( 1.5f * i * verticalDistance));
        }
	}
	
    // Spawn a row of blocks
    void SpawnBlockColumn (float _xPos, float _yPos)
    {
        for (int i = 0; i < numBricks; i++)
        {
            Instantiate(brick, new Vector3(_xPos, _yPos + (i * verticalDistance), 0), Quaternion.identity);
        }
    }
}
