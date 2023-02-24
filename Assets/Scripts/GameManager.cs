/*
    GameManager.cs was a script from the aa-Replica tutorial.
    It controls what happens when two pins collide.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool gameHasEnded = false;
    public Rotator rotator;
    public Spawner spawner;
    public Animator animator;

    // disables Rotator and Spawner game objects, sets the endgame trigger animation to play,
    // destroys all pins, plays sound effect, resets win condition, and sets gameHasEnded back
    // to true to be used again.
    public void EndGame(){
        if (gameHasEnded){
            return;
        }

        rotator.enabled = false;
        spawner.enabled = false;
        animator.SetTrigger("EndGame");
        var Pins = GameObject.FindGameObjectsWithTag("Pin");
        foreach (var Pin in Pins)
        {
        Destroy(Pin);
        }
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        DataManager.winPins = 10;
        gameHasEnded = true;
    }

    // Reloads the current level scene, used by the animator.
    public void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


}
