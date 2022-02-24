using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timeRemaining = 20;
    public Text coutdownTxt;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            coutdownTxt.text = timeRemaining.ToString("f0") + "";
        }
        else
        {
            CreateEnemy.timeIsDone = true;
        }
    }
}
