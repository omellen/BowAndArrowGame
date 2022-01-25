using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScript : MonoBehaviour
{   
    void Start()
    {
        HealthBarHandler.SetHealthBarValue(1);
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision c)
    {
        if(c.collider.tag == "Enemy")
        {
            HealthBarHandler.SetHealthBarValue(HealthBarHandler.GetHealthBarValue() - 0.01f);
        }
    }
}
