using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPlane : MonoBehaviour
{
    [SerializeField] GameObject player = null;

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x,
                                            transform.position.y,
                                            0);
    }
    private void OnTriggerEnter() 
    {
        SceneManager.LoadScene(0);
    }
}
