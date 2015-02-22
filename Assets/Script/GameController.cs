using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour 
{
    public GameObject brick;
    public float xPosition;
    public float yPosition;
    public int numBricks;
    public int numColumns;
    public float verticalDistance;
    public float horizontalDistance;

	// Use this for initialization
	void Start () 
    {
        spawnBlockColumn(xPosition, yPosition, numBricks);
	}
	
    // Spawn a row of blocks
    void spawnBlockColumn (float xPos, float yPos, int numBlocks)
    {
        for (int i = 0; i < numBlocks; i++)
        {
            Instantiate(brick, new Vector3(xPos, yPos + (i * verticalDistance), 0), Quaternion.identity);
        }
    }
}
