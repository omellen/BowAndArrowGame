using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HealthScript : MonoBehaviour
{
    public GameObject barrier;
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1);
    }

    void Update()
    {
        if(HealthBarHandler.GetHealthBarValue() == 0)
        {
            Destroy(barrier);
            if(barrier.active == false)
            {
                GameManager.gameIsOver = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<NavMeshAgent>().enabled = false;
    }
}
