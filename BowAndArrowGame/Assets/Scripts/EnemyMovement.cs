using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public Transform tower;


    public List<GameObject> enemyArray = new List<GameObject>();

    void Start()
    {
        enemyArray = GameObject.Find("CreateEnemy").GetComponent<CreateEnemy>().enemyArray;
    }

    void Update()
    {
        enemy.transform.LookAt(tower);

        enemy.AddComponent<Rigidbody>().AddForce(new Vector3(0, 0, -500));

    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.name == "arrow")
        {
            Destroy(enemy);
        }
    }
}