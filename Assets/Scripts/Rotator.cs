/*
    Rotator.cs was a script from the aa-Replica tutorial.
    Controls Rotator object speed and movement.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;
    public int numOfPinned = 0;

    // At start set Rotator speed to be what was set to by
    // Rotator speed slider.
    public void Start(){
        speed = UiManager.rotatorSpeed;
    }

    // Keeps the Rotator rotating.
    void Update (){
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
