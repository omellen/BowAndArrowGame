using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject GOPanel;
    public GameObject TargetCursor;
    public GameObject HealthBar;

    void Start()
    {
        
    }

    public static bool StartInvokingAgain()
    {
        return true;
    }

    public void RestartGame()
    {
        HealthBar.SetActive(true);
        TargetCursor.SetActive(true);
        GOPanel.SetActive(false);
        StartInvokingAgain();
    }
}
