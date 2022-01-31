using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public Transform target;

    float lookRadius = 80f;
    UnityEngine.AI.NavMeshAgent agent;

    public List<GameObject> enemyArray = new List<GameObject>();

    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        CreateEnemy tgt = new CreateEnemy();
        enemyArray = tgt.enemyArray;
        enemy.transform.LookAt(target);

        foreach (GameObject number in enemyArray)
        {
            float distance = Vector3.Distance(target.position, transform.position);

            if (distance <= lookRadius)
                agent.SetDestination(target.position);

            //Debug.Log(number);
            //number.GetComponent<Rigidbody>().AddForce(number.transform.forward * 10);
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

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}