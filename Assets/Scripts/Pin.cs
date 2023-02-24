/*
    Pin.cs was a script from the aa-Replica tutorial.
    Controls pin speed, movement, and collision with Rotator.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    // On start set speed to speed chosen by pin speed slider.
    void Start(){
        speed = UiManager.pinSpeed;
    }

    // Keeps the pin objects moving until they reach the Rotator.
    void Update (){
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    // Pins the pins to the Rotator, Increases speed every time a pin
    // is pinned to the Rotator, after 5 pins are pinned the following
    // pin will cause the Rotator to swap spinning directions while
    // still increasing the speed, subtracts from the number of pins
    // needed to win if not already at 0, pin is set to as pinned,
    // and if a pin touches another pin it activates the EndGame
    // function.
    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Rotator"){
            transform.SetParent(col.transform);
            if (col.GetComponent<Rotator>().numOfPinned == 5){
                col.GetComponent<Rotator>().speed *= -1;
                col.GetComponent<Rotator>().numOfPinned -= 5;
            }
            else if (col.GetComponent<Rotator>().speed < 0){
                col.GetComponent<Rotator>().speed -= 5f;
                col.GetComponent<Rotator>().numOfPinned += 1;
            }
            else{
                col.GetComponent<Rotator>().speed += 5f;
                col.GetComponent<Rotator>().numOfPinned += 1;
            }
            Score.PinCount++;
            if (DataManager.winPins != 0){
                DataManager.winPins--;
            }
            isPinned = true;
        }
        else if(col.tag == "Pin"){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
