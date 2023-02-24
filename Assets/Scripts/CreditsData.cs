/*
    CreditsData.cs controls the player name and highscore text displayed on the credits screen.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsData : MonoBehaviour
{
    public Text credHighScoreText;
    public Text credPlayerName;

    // sets the player name and highscore text boxes to display the current
    // player name and highscore. 
    void Start()
    {
        credPlayerName.text = UiManager.playerName;
        credHighScoreText.text = Score.highScore.ToString();
    }

}
