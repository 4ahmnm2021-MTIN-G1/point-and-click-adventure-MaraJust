using System.Numerics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Transform thisTransform;
    public UnityEngine.Vector3 mousePos;
    public UnityEngine.Vector3 worldPos;
    public UnityEngine.Vector3 playerPos;
    public float speed = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPos = thisTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        thisTransform.position = UnityEngine.Vector3.MoveTowards(thisTransform.position, playerPos, speed);
    }

    public void SetNewDestination()
    {
        mousePos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(mousePos);
        playerPos = new UnityEngine.Vector3(worldPos.x, worldPos.y, thisTransform.position.z);
    }
}
