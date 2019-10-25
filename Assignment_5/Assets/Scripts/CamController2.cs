using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController2 : MonoBehaviour {

    public Transform player;

    Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;

    }

    void LateUpdate()
    {

        transform.position = new Vector3(player.transform.position.x, 40f, player.transform.position.z - 40f);

    }
}
