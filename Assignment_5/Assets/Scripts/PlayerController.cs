using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    public float speed = 800.0f;
    public Text scoreText;
    public static int count = 0;
    public static int highScore;
    public static int rCount;
    private AudioSource movingSound;
    Rigidbody rb;
    private float ballSpeed;

    bool isMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movingSound = GetComponent<AudioSource>();
        
        
        Debug.Log(rCount);
        
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        GetComponent<Rigidbody>().AddForce(movement * ballSpeed * Time.deltaTime);
    }

    void Update()
    {
        ballSpeed = PlayerName.ballSpeedValue * speed;
        if (rb.velocity.x != 0)
        {
            isMoving = true;
        }
        else
            isMoving = false;

        if (isMoving)
        {
            if (!movingSound.isPlaying)
                movingSound.Play();
        }
        else
            movingSound.Stop();
        
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PickUp")
        {
            other.gameObject.SetActive(false);
            count += 1;
            rCount += 1;
            scoreText.text = PlayerName.ShowName + "Score: " + count;
            Debug.Log("count = " + count);

            if (highScore < count)
                highScore = count;
        }

        if (other.gameObject.tag == "PlayGame")
        {
            SceneManager.LoadScene("Main");
        }

        if (other.gameObject.tag == "Exitgame")
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

        if (other.gameObject.tag == "PlayAgain")
        {
            DropdownLives.myIndex = 0;
            count = 0;
            SpiderSpawn.roundCount = 0;
            rCount = 0;
            SpiderSpawn.countdownvis = false;
            SceneManager.LoadScene("Intro");
        }

    }

}