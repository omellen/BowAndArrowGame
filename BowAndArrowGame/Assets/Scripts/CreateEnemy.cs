using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
    public GameObject enemy;
    private int xPos;
    private int zPos;
    private int enemyCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 4, 8);
    }

    Vector3 getRandomPos()
    {
        float _x = Random.Range(-20, 20);
        float _y = 1;
        float _z = 20;

        Vector3 newPos = new Vector3(_x, _y, _z);
        return newPos;
    }
    void Spawn()
    {
        Instantiate(enemy, getRandomPos(), Quaternion.identity);
    }
}
