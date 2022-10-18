using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; 
    public Vector2 offset = new Vector2 (0,2);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
