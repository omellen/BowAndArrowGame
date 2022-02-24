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
            barrier.SetActive(false);
            if(!barrier.activeSelf)
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
