using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    private float depth = 0.3f;
    public GameObject arrow;
    public GameObject enemy;

    private GameObject currentE;
    public List<GameObject> enemyArray = new List<GameObject>();

    void Start()
    {
        enemyArray = GameObject.Find("CreateEnemy").GetComponent<CreateEnemy>().enemyArray;
    }


    private void OnCollisionEnter(Collision c)
    {
        string name = "";

        Debug.Log(c.collider.tag);
        if (c.collider.tag == "Enemy")
        {
            Destroy(c.collider.gameObject);
            Destroy(arrow);
        }



    }
}
