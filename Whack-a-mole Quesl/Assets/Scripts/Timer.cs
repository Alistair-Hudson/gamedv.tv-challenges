using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text timerText; 
    float elapsedTime = 0f;
    
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        elapsedTime += Time.deltaTime;
        int absoluteTime = (int)elapsedTime;
        timerText.text = absoluteTime.ToString();
    }
}
