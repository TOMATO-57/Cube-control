using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 distance; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerPos.position);

        transform.position = playerPos.position + distance;
    }
}
