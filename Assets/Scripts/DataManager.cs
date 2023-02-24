/*
    DataManager.cs applies colors to the Rotator and score related UI text,
    also contains the win condition, win condition check bool, 
    and update number of pins remaining.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataManager : MonoBehaviour
{
    public GameObject Rotator;
    public Text scoreText;
    public Text highScoreText;
    public Text highScoreNum;
    public Text playerName;
    public Text pinsToWin;

    public static bool hasWon = false;
    public static int winPins = 10;
    
    // On start set number of pins needed to win, update text to show number of pins,
    // set player's name to display, and invoke the color changer to change colors.
    void Start(){
        winPins = 10;
        pinsToWin.text = winPins.ToString();
        playerName.text = UiManager.playerName;
        Invoke("changeRotatorColor", 0);
    }

    public void changeRotatorColor(){
        switch(UiManager.color){
            case 3:
                Rotator.GetComponent<SpriteRenderer>().color = Color.white;
                scoreText.GetComponent<Text>().color = Color.black;
                highScoreText.GetComponent<Text>().color = Color.black;
                highScoreNum.GetComponent<Text>().color = Color.black;
                break;

            case 2:
                Rotator.GetComponent<SpriteRenderer>().color = Color.green;
                scoreText.GetComponent<Text>().color = Color.black;
                highScoreText.GetComponent<Text>().color = Color.black;
                highScoreNum.GetComponent<Text>().color = Color.black;
                break;

            case 1:
                Rotator.GetComponent<SpriteRenderer>().color = Color.blue;
                scoreText.GetComponent<Text>().color = Color.white;
                highScoreText.GetComponent<Text>().color = Color.white;
                highScoreNum.GetComponent<Text>().color = Color.white;
                break;

            default:
                Rotator.GetComponent<SpriteRenderer>().color = Color.black;
                scoreText.GetComponent<Text>().color = Color.white;
                highScoreText.GetComponent<Text>().color = Color.white;
                highScoreNum.GetComponent<Text>().color = Color.white;
                break;
      }
    }

    // Updates pinsToWin text
    void Update(){
        pinsToWin.text = winPins.ToString();
    }

    


}
