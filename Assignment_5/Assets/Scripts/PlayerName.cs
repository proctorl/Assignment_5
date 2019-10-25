using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    public InputField playerName;
    public static string ShowName;
    public Slider ballSpeed;
    public Slider targetSpeed;
    public static float ballSpeedValue;
    public static float targetSpeedValue;
    
    


    void Update()
    {
        if (string.IsNullOrEmpty(playerName.text) == false)
            ShowName = playerName.text;
        else
            ShowName = "Player";

        ballSpeedValue = ballSpeed.value;
        targetSpeedValue = targetSpeed.value;
    }

    

    

}
