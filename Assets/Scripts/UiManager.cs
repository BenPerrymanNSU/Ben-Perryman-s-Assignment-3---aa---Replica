/*
    UiManager.cs controls the ui for the Title scene, saves setting changes
    for other scripts to use.
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public Slider rotationSpeedSlider;
    public Slider pinSpeedSlider;
    public Dropdown rotatorColorDropdown;
    public Text rotationSpeedNumText;
    public Text pinSpeedNumText;
    public Text rotationSpeedText;
    public Text pinSpeedText;
    public Text colorSelectText;
    public Button settingsButton;
    public Image settingsBackground;
    public Image settingsBackgroundTri;
    public InputField nameInput;

    public static float rotatorSpeed = 100f;
    public static float pinSpeed = 20f;
    public static int color = 0;
    public static string playerName = "";

    private bool Pressed = false;

    // At start set each slider, dropdown, and input field
    // to previous selected values or default. 
    void Start(){
        rotationSpeedSlider.value = rotatorSpeed;
        pinSpeedSlider.value = pinSpeed;
        rotatorColorDropdown.value = color;
        nameInput.text = playerName;
    }

    // When the settings button is pressed it enables and disables
    // all settings menu text, sliders, and dropdown.
    public void settingsButtonPressed(){
        if(Pressed == false){
            settingsBackground.gameObject.SetActive(true);
            settingsBackgroundTri.gameObject.SetActive(true);
            rotationSpeedSlider.gameObject.SetActive(true);
            rotationSpeedText.gameObject.SetActive(true);
            pinSpeedSlider.gameObject.SetActive(true);
            pinSpeedText.gameObject.SetActive(true);
            pinSpeedNumText.gameObject.SetActive(true);
            rotationSpeedNumText.gameObject.SetActive(true);
            rotatorColorDropdown.gameObject.SetActive(true);
            colorSelectText.gameObject.SetActive(true);
            Pressed = true;
        }
        else if(Pressed == true){
            settingsBackground.gameObject.SetActive(false);
            settingsBackgroundTri.gameObject.SetActive(false);
            rotationSpeedSlider.gameObject.SetActive(false);
            rotationSpeedText.gameObject.SetActive(false);
            pinSpeedSlider.gameObject.SetActive(false);
            pinSpeedText.gameObject.SetActive(false);
            pinSpeedNumText.gameObject.SetActive(false);
            rotationSpeedNumText.gameObject.SetActive(false);
            rotatorColorDropdown.gameObject.SetActive(false);
            colorSelectText.gameObject.SetActive(false);
            Pressed = false;
       }
    }

    // Saves Rotator speed value selected by slider and displays it.
    public void changeRotatorSlider(){
        rotatorSpeed = rotationSpeedSlider.value;
        rotationSpeedNumText.text = rotatorSpeed.ToString();
    }

    // Saves Pin speed value selected by slider and displays it.
    public void changePinSlider(){
        pinSpeed = pinSpeedSlider.value;
        pinSpeedNumText.text = pinSpeed.ToString();
    }

    // Saves Rotator color value selected by dropdown.
    public void colorRotatorSelect(){
        color = rotatorColorDropdown.value;
    }

    // Saves name entered into input field by player.
    public void setPlayerName(){
		playerName = nameInput.text.ToString();
	}
}
