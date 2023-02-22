using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private bool spaceCoolDown = false;
    public float speed = 100f;
    public int numOfPinned = 0;
    public Animator animator;

    public void Start(){
        animator = GetComponent<Animator>();
    }

    void Update (){
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space)){
            if (spaceCoolDown == false){
                Debug.Log("Animation played!");
                animator.SetTrigger("Rotator");
                spaceCoolDown = true;
                Invoke ("coolDownReset", 10.0f);
            }
        }
    }

    void coolDownReset(){
        spaceCoolDown = false;
    }

}
