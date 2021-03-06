﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Slider mySlider;

    public float acceleration;
    public float maxSpeed;
    private Rigidbody rigidBody;
    private KeyCode[] inputKeys;
    private Vector3[] directionsForKeys;

    float sliderValue;
    

    void Start()
    {
        inputKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
        directionsForKeys = new Vector3[] { Vector3.forward, Vector3.left, Vector3.back, Vector3.right };
        rigidBody = GetComponent<Rigidbody>();

        //Added speed adjustment
        mySlider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < inputKeys.Length; i++)
        {
            var key = inputKeys[i];

            if (Input.GetKey(key))
            {
                Vector3 movement = directionsForKeys[i] * acceleration * Time.deltaTime;
                movePlayer(movement);
            }
        } 


    }

    void movePlayer(Vector3 movement)
    {
        if(rigidBody.velocity.magnitude * acceleration > maxSpeed)
        {
            rigidBody.AddForce(movement * -1);

        } else
        {
            rigidBody.AddForce(movement);
        }
    }

    public void RollSpeed(float newMaxSpeed)
    {
        //Edited maxSpeed with sliderValue
        maxSpeed = (newMaxSpeed * mySlider.value);

    }

    public void ValueChangeCheck()
    {
        Debug.Log(mySlider.value);

        sliderValue = mySlider.value;
    }

    public void SliderGoFast()
    {
        maxSpeed = maxSpeed * mySlider.value;
    }
}
