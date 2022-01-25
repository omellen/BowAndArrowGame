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
        //enemyArray = GameObject.Find("CreateEnemy.cs").GetComponent<CreateEnemy>().enemyArray;
    }

    void Update()
    {
        //enemyArray = GameObject.Find("CreatingThyEnemy").GetComponent<CreateEnemy>().enemyArray;
        CreateEnemy tgt = new CreateEnemy();
        enemyArray = tgt.enemyArray;
        enemy.transform.LookAt(tower);
        foreach (GameObject number in enemyArray)
        {
            Debug.Log(number);
            number.GetComponent<Rigidbody>().AddForce(number.transform.forward * 10);
        }

        //  enemy.AddComponent<Rigidbody>().AddForce(new Vector3(0, 0, -500));

    }

    private void OnCollisionEnter(Collision c)
    {
        if (c.collider.name == "arrow")
        {
            Destroy(enemy);
            Destroy(c.collider.gameObject);
        }
        if (c.collider.tag == "Barrier")
        {
            HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.05f);
        }
    }
}