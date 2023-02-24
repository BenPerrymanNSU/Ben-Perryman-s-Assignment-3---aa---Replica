/*
    PauseFunction.cs controls the pause functionality, pause menu,
    and updates certain UI elements to appear when win condition is met.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseFunction : MonoBehaviour
{
    private GameObject pinSpawner;
    public Button continueButton;
    public Text pauseMenu;
    public Image background;
    public Button returnButton;
    public Text text;
    public Text highScoreText;
    public Text highScoreNum;
    public Text checkText;

    private bool Paused = false;

    // At start set the timescale back to normal
    void Start(){
        Time.timeScale = 1;
    }

    // Checks for if the win conditions are met to display a warning message
    // to the player to check the pause menu for the exit button, also checks
    // for the esc key press to pause the game.
    void Update(){
        if (DataManager.winPins == 0 || DataManager.hasWon == true){
            checkText.gameObject.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(Paused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    // pauses the game scene, disables pin spawner, checks win conditions
    // to enable exit button to appear in pause menu, if the player has
    // reached 0 pins needed then it sets hasWon bool to true to let the
    // player quit at any time, enables pause menu graphics, disables
    // score related graphics.
    void PauseGame()
    {
        Time.timeScale = 0;
        
        Paused = true;
        GameObject pinSpawner = GameObject.Find("PinSpawnPoint");
        pinSpawner.GetComponent<Spawner>().enabled = false;
        if (DataManager.winPins == 0 || DataManager.hasWon == true){
            DataManager.hasWon = true;
            continueButton.gameObject.SetActive(true);
        }
        background.gameObject.SetActive(true);
        pauseMenu.gameObject.SetActive(true);
        returnButton.gameObject.SetActive(true);
        text.gameObject.SetActive(false);
        highScoreText.gameObject.SetActive(false);
        highScoreNum.gameObject.SetActive(false);
    }

    // resumes the game scene, enables pin spawner, disables pause menu
    // graphics, enables score related graphics.
    public void ResumeGame()
    {
        Time.timeScale = 1;
        
        Paused = false;
        GameObject pinSpawner = GameObject.Find("PinSpawnPoint");
        pinSpawner.GetComponent<Spawner>().enabled = true;
        continueButton.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
        pauseMenu.gameObject.SetActive(false);
        returnButton.gameObject.SetActive(false);
        text.gameObject.SetActive(true);
        highScoreText.gameObject.SetActive(true);
        highScoreNum.gameObject.SetActive(true);
    }
}
