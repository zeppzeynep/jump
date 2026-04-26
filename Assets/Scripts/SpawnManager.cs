using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public GameObject obstaclePrefab;
    private float startDelay = 2;
    private float repeatRate = 2;
    private Vector3 spawnCoord= new Vector3(25, 0, 0);
   

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();    
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnCoord, obstaclePrefab.transform.rotation);
        }
    }
}
