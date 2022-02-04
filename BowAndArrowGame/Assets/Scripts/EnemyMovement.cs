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
        enemyArray = GameObject.Find("CreatingThyEnemy").GetComponent<CreateEnemy>().enemyArray;

        foreach (GameObject number in enemyArray)
        {
            //Debug.Log(number);


            float distance = Vector3.Distance(target.position, transform.position);

            if (distance <= lookRadius)
                agent.SetDestination(target.position); 
        }
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