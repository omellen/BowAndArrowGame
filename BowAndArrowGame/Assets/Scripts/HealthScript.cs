using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }
    }
    
}
