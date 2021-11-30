using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float launchSpeed = 80f;

    public GameObject Arrow;
    public Transform ShotPoint;
    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion arrowRotation = new Quaternion();
            GameObject createArrow = Instantiate(Arrow, ShotPoint.position, arrowRotation);
            createArrow.transform.LookAt(Player);
            createArrow.transform.Rotate(0, 90, 0);

            createArrow.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 80);

            //createArrow.transform.Translate(createArrow.transform.forward * launchSpeed);
            
            
        }
    }
}
