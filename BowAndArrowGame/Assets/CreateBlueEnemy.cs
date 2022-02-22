using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlueEnemy : MonoBehaviour
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


    //repeats spawn
    void Start()
    {
        InvokeRepeating("Spawn", 1, 9);
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


    void Update()
    {
        gameIsOver = GameManager.IsGameOver();
        if (gameIsOver == true)
            DestroyAllEnemies();
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
}
