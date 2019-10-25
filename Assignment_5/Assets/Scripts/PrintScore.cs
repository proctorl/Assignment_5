using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrintScore : MonoBehaviour
{
    public Text playerScore;
    public Text highScore;
    public Text ballSpeed;
    public Text targetSpeed;
    public Text rounds;
    public Text countDown;


    public void Update()
    {
        highScore.text = PlayerName.ShowName + "'s Score: " + PlayerController.count.ToString();
        playerScore.text = "High Score: " + PlayerController.highScore.ToString();
        ballSpeed.text = "Ball Speed: " + PlayerName.ballSpeedValue.ToString("F1");
        targetSpeed.text = "Target Speed: " + PlayerName.targetSpeedValue.ToString("F1");
        
        countDown.text = "Next Round Begins In: " + SpiderSpawn.countDown.ToString();

        if ((SpiderSpawn.roundCount -1)== 0)
            rounds.text = "Last Round!";
        else
            rounds.text = "Rounds Remaining: " + (SpiderSpawn.roundCount - 1).ToString();

        if (SpiderSpawn.countdownvis)
        {
            rounds.enabled = true;
            countDown.enabled = true;
        }
        else
        {
            countDown.enabled = false;
            rounds.enabled = false;
        }
    }
}
