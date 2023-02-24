/*
    Spawner.cs was a script from the aa-Replica tutorial.
    Controls pin spawning and player pin shooting.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    // checks if left click was pressed to spawn a pin, plays
    // a sound effect when fired.
    void Update (){
        if (Input.GetButtonDown("Fire1")){
            SpawnPin();
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }

    // Creates a new pin prefab clone.
    public void SpawnPin (){
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
