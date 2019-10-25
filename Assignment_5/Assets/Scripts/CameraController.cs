using UnityEngine;
using System;

public class CameraController : MonoBehaviour
{
    public Transform player;
    
    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
        
    }

    void LateUpdate()
    {
        
        transform.position = new Vector3(player.transform.position.x, 70f, player.transform.position.z - 72f);

    }
}