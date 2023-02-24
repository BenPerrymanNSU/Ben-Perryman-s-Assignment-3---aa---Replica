/*
    ButtonManager.cs controls the buttons in each scene
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{

    // If the player name has been set and is not empty then
    // this will load the next scene in the build order.
    public void nextScene(){
        if (UiManager.playerName != ""){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else{
            return;
        }
    }

    // Resets hasWon bool check and loads the first scene
    // in the build order.
    public void titleScene(){
        DataManager.hasWon = false;
        SceneManager.LoadScene(0);
    }

    // Exits the Unity play window
    public void exitGame(){
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
