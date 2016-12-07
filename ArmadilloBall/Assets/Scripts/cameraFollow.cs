﻿using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {

    public GameObject player;
    private Vector3 playerOffset;

    // Use this for initialization
    void Start()
    {
        playerOffset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(player.transform);
        transform.position = player.transform.position + playerOffset;
    }
}
