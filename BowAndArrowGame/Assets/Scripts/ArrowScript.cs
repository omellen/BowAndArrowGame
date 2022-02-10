using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
  
    public GameObject arrow;
    public GameObject enemy;

    private GameObject currentE;
    public List<GameObject> enemyArray = new List<GameObject>();


    public static float count;

    void Start()
    {
        enemyArray = GameObject.Find("CreateEnemy").GetComponent<CreateEnemy>().enemyArray;
    }

     void Update()
    {
        Debug.Log(count);
    }

    //when the arrow hits an enemy, it destroys it
    private void OnCollisionEnter(Collision c)
    {

        //Debug.Log(c.collider.tag);
        if (c.collider.tag == "Enemy")
        {
            Destroy(c.collider.gameObject);
            Destroy(arrow);
        }

    }
}
