using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    void Update (){
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Rotator"){
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if(col.tag == "Pin"){
            FindObjectOfType<GameManager>().EndGame();
        }
    }

/*
    public void getSpeed(Collider2D col){
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
    }
*/
}
