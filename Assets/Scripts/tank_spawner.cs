﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tank_spawner : MonoBehaviour
{
    public GameObject tankPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(tankPrefab, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
