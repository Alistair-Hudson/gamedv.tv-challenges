using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorer : MonoBehaviour
{
    [SerializeField] ParticleSystem celebration;
    bool hasChildren = true;
    float celebrationTimeOut = 1f;

    void Update()
    {
        if (transform.childCount == 0 && celebrationTimeOut > 0f)
        {
            celebrationTimeOut -= Time.deltaTime;
            celebration.Play();
        }
        if (celebrationTimeOut <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
