using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    private int xPos;
    private int zPos;
    private int enemyCount = 0;

    public Transform player;

    private GameObject currentE;
    public List<GameObject> enemyArray = new List<GameObject>();

   
    void Start()
    {
        InvokeRepeating("Spawn", 4, 8);
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-20, 20);
        float _y = 1.8f;
        float _z = 20;

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }
    void Spawn()
    {
        currentE = Instantiate(enemy, getRandomPos(), new Quaternion(0,180,0,0));
        currentE.transform.LookAt(player);
        enemyArray.Add(currentE);
        
    }
}
