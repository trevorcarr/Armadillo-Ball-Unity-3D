using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotMover : MonoBehaviour
{

    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform child = transform.GetChild(0);
        child.parent = null;
        transform.position = player.transform.position;
        child.parent = transform;
    }
}