    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{
    float launchSpeed = 80f;

    public GameObject Arrow;
    public Transform ShotPoint;
    public Transform Player;
    public Transform cam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Quaternion arrowRotation = cam.rotation;
            GameObject createArrow = Instantiate(Arrow, ShotPoint.position, arrowRotation);

            createArrow.GetComponent<Rigidbody>().velocity = createArrow.transform.forward * launchSpeed;
        }
    }

    private void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.collider.tag);
        if (c.collider.name == "Target")
        {
            //Quaternion arrowRotation = cam.rotation;
            //GameObject createArrow = Instantiate(Arrow, ShotPoint.position, arrowRotation);

            //createArrow.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
