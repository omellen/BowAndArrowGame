using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateArrowScript : MonoBehaviour
{
    float launchSpeed = 100f;

    public GameObject Arrow;
    public Transform ShotPoint;
    public Transform Player;
    public Transform cam;
    public GameObject target;

    private GameObject currentArrow;
    float depth = 0.3f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Quaternion arrowRotation = cam.rotation;
            GameObject createArrow = Instantiate(Arrow, ShotPoint.position, arrowRotation);

            createArrow.GetComponent<Rigidbody>().velocity = createArrow.transform.forward * launchSpeed;

            currentArrow = createArrow;
        }
    }
}
