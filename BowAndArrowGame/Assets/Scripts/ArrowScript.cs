using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    private float depth = 0.3f;

    private void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.collider.name);
        if (c.transform.tag == "tip2")
        {
            //c.transform.parent = c.collider.transform;
            //c.rigidbody.isKinematic = true;
            //c.transform.Translate(depth * Vector3.forward);
            //c.transform.parent = transform;
            
        }
    }
}
