using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject TargetCursor;
    public GameObject HealthBar;

    void Start()
    {
        HealthBar.SetActive(true);
        TargetCursor.SetActive(true);
        GOPanel.SetActive(false);
        StartInvokingAgain();
    }

    public static bool StartInvokingAgain()
    {
        return true;
    }

}
