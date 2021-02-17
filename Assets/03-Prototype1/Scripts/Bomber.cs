﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{

    [Header("Set in Inspector")]

    public GameObject bombPrefab;

    public float speed = 1f;

    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 0.1f;

    public float secondsBetweenBombDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DropBomb", 2f);
    }

    void DropBomb()
    {
        GameObject bomb = Instantiate<GameObject>(bombPrefab);
        bomb.transform.position = transform.position;
        Invoke("DropBomb", secondsBetweenBombDrops);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate()
    {
        if ( Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
