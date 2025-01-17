﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfRange : MonoBehaviour
{
    private Transform cameraObj;

    private float discBtw;
    [SerializeField]private float range = 8f;

    private void Start()
    {
        cameraObj = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }
    private void Update()
    {
        discBtw = Vector2.Distance(transform.position, cameraObj.position);

        if (discBtw > range)
        {
            if (transform.position.y < cameraObj.position.y)
            {
                Destroy(gameObject);
            }
        }
    }
}