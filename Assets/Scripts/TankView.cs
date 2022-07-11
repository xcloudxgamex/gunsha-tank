﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        GameObject camera = GameObject.FindGameObjectWithTag("MainCamera");
        camera.transform.SetParent(transform);
        camera.transform.position = new Vector3(0f, 3f, -4f);
    }

    void Update()
    {
        Movement();

        if (movement != 0)
        {
            tankController.Move(movement, tankController.getTankModel().movementSpeed);
        }

        if(rotation != 0)
        {
            tankController.Rotate(rotation, tankController.getTankModel().rotationSpeed);
        }
    }

    public void setTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody getRigidbody()
    {
        return rb;
    }

   private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");
    }
}
