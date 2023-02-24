/*
    Score.cs was a script from the aa-Replica tutorial.
    Controls score and high score values and displays.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public static int highScore;
    public int savedHighScore = 0;
    public Text text;
    public Text highScoreText;

    // At start set highscore to be previous highscore and 
    // display it or display default, resets pin counter.
    void Start(){
        savedHighScore = highScore;
        highScoreText.text = savedHighScore.ToString();
        PinCount = 0;
    }

    // Checks to update the pin counter to display score and updates
    // highscore if pin counter exceeds highscore value, displays new
    // highscore value.
    void Update(){
        text.text = PinCount.ToString();
        if (PinCount > savedHighScore){
            savedHighScore = PinCount;
            highScore = PinCount;
            highScoreText.text = savedHighScore.ToString();
        }
    }
}
