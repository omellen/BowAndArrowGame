using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    public float launchSpeed = 80f;

    public GameObject Arrow;
    public Transform ShotPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Quaternion arrowRotation = new Quaternion(ShotPoint.rotation.w, 0, ShotPoint.rotation.y, ShotPoint.rotation.z);
            GameObject createArrow = Instantiate(Arrow, ShotPoint.position, arrowRotation);
            createArrow.GetComponent<Rigidbody>().velocity = ShotPoint.transform.up * launchSpeed;
        }
    }
}
