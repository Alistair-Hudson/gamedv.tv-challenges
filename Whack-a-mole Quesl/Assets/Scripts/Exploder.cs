using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exploder : MonoBehaviour
{
    private void Start()
    {
        var particleSystem = GetComponentInChildren<ParticleSystem>().emission;
        particleSystem.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent<Mover>(out Mover player))
        {
            return;
        }
        var particleSystem = GetComponentInChildren<ParticleSystem>().emission;
        particleSystem.enabled = true;
        print("Aww, you got me");
        Destroy(gameObject, 1f);         
    }
}
