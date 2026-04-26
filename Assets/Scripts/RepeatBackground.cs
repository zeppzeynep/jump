using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float repeatWidth;
    private Vector3 startPos;
    void Start()
    {
        repeatWidth = GetComponent<BoxCollider>().size.x;
        startPos = transform.position;   
    }
        
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < startPos.x - repeatWidth/2)
        {
            transform.position = startPos;

        }
    }
}
