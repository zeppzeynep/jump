using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private PlayerController playerControllerScript;
    public int speed = 35;
    public float leftBounds = -10;

    void Start()
    {
     playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();   
    }

    void Update()
    {
        if ( playerControllerScript.gameOver==false)
        {
            transform.Translate(Vector3.left*Time.deltaTime*speed);
        }

        if(transform.position.x < leftBounds && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}
