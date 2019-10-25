using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpiderSpawn : MonoBehaviour {

	public GameObject spider;
    public bool roundOver = true;
    float deathTimer = 5;
    static float spawnDelay = 0;
    float randomX;
    float randomZ;
    int spawnAmount = 6;
    public static float countDown;
    public static bool countdownvis;
    public static int roundCount = 0;
    Quaternion targetSpeed;

    void Start()
    {


        roundCount = DropdownLives.myIndex - 1;
        targetSpeed = Quaternion.Euler(0,PlayerName.targetSpeedValue,0);
        for (int i = 0; i < spawnAmount; i++)
        {
            randomX = Random.Range(-40.0f, 45.0f);
            randomZ = Random.Range(-40.0f, 45.0f);
            Spawn();
        }
    }

    void Update()
    {
        if (PlayerController.rCount == spawnAmount)
        {
            if (roundCount == 0)
                SceneManager.LoadScene("Exit");

            countdownvis = true;
            deathTimer -= 1 * Time.deltaTime;
            countDown = Mathf.Round(deathTimer);
            
            if (deathTimer <= spawnDelay)
            {
                roundCount--;
                countdownvis = false;
            }
        }
        
        if (deathTimer <= spawnDelay)
        {
            deathTimer = 5;
            Debug.Log("spawn");
            spawnAmount = Random.Range(4, 8);
            for (int i = 0; i < spawnAmount; i++)
            {
                randomX = Random.Range(-40.0f, 45.0f);
                randomZ = Random.Range(-40.0f, 45.0f);
                Spawn();
            }
            PlayerController.rCount = 0;
        }
    }
    public void Spawn()
    {
            Instantiate(spider, new Vector3(randomX, 1, randomZ), targetSpeed);
    }
}
