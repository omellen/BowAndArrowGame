using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject target;
    public Transform player;
    private GameObject currentE;

    private int xPos;
    private int zPos;

    
    public List<GameObject> enemyArray = new List<GameObject>();
    private float numOfEnemies = 0;

    bool gameIsOver = GameManager.gameIsOver;

    public Text waveTxt;
    private int waveNumber = 0;
    private float repeatRate = 5f;
    public static bool timeIsDone = false;
    private bool readyForNextWave = false;


    //repeats spawn
    void Start()
    {
        // InvokeRepeating("Spawn", 1, 1);
        StartWave();
    }

    void Update()
    {
        gameIsOver = GameManager.IsGameOver();
        if (gameIsOver == true)
            DestroyAllEnemies();

        if (timeIsDone)
        {
            DestroyAllEnemies();
            Timer.timeRemaining = 20;
            timeIsDone = false;
            waveNumber += 1;
            repeatRate -= 0.5f;
            waveTxt.text = "Wave: " + waveNumber;
            InvokeRepeating("Spawn", 1, repeatRate);
        }
            
    }

    //where enemy spawns
    Vector3 getRandomPos()
    {
        float _x = Random.Range(-20, 20);
        float _y = 5f;
        float _z = 45;

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }

    //creates a new enemy
    void Spawn()
    {
        currentE = Instantiate(enemy, getRandomPos(), new Quaternion(0, 180, 0, 0));
        currentE.transform.LookAt(target.transform);
        numOfEnemies += 1;
        currentE.name = "Enemy" + numOfEnemies;
        enemyArray.Add(currentE);
    }

    //destroys all enemies
    void DestroyAllEnemies()
    {
        foreach (GameObject x in enemyArray)
        {
            Destroy(x.gameObject);
        }
        CancelInvoke();
        enemyArray.Clear();
    }


    private void StartWave()
    {
        waveNumber = 1;
        waveTxt.text = "Wave: " + waveNumber;

        InvokeRepeating("Spawn", 1, repeatRate);
    }

    
}
