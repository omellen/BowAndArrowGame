using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public GameObject enemy;
    public float forwardForce = 200f;

    private void FixedUpdate()
    {
        enemy.GetComponent<Rigidbody>().AddForce(0, 0, forwardForce * Time.deltaTime);

    }
}