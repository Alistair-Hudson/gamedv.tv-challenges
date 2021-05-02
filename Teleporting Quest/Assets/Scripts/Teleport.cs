using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// GameDev.tv Challenge Club. Got questions or want to share your nifty solution?
// Head over to - http://community.gamedev.tv

public class Teleport : MonoBehaviour
{
    [SerializeField] Transform teleportTarget;
    [SerializeField] GameObject player;
    [SerializeField] Light areaLight;
    [SerializeField] Light mainWorldLight;

    //[SerializeField] float minX = 0f;
    //[SerializeField] float maxX = 10f;
    //[SerializeField] float minY = 0f;
    //[SerializeField] float maxY = 10f;
    //[SerializeField] float minZ = 0f;
    //[SerializeField] float maxZ = 10f;

    void Start() 
    {
        // CHALLENGE TIP: Make sure all relevant lights are turned off until you need them on
        // because, you know, that would look cool.
        areaLight.gameObject.SetActive(false);
        mainWorldLight.gameObject.SetActive(false);
        // Challenge 5: StartCoroutine ("BlinkWorldLight");
        StartCoroutine("BlinkWorldLight");
    }

    void OnTriggerEnter(Collider other) 
    {
        // Challenge 2: TeleportPlayer();
        TeleportPlayer();
        // Challenge 3: DeactivateObject();
        DeactivateObject();
        // Challenge 4: IlluminateArea();
        IlluminateArea();
        // Challenge 6: TeleportPlayerRandom();
        //TeleportPlayerRandom();
    }

    void TeleportPlayer()
    {
        player.transform.position = teleportTarget.position;
    }

    void DeactivateObject()
    {
        gameObject.SetActive(false); 
    }

    void IlluminateArea()
    {
        areaLight.gameObject.SetActive(true); 
    }

    IEnumerator BlinkWorldLight()
    {
        while (true)
        {

            mainWorldLight.gameObject.SetActive(!mainWorldLight.gameObject.activeSelf);
            yield return new WaitForSeconds(1f);
            mainWorldLight.gameObject.SetActive(!mainWorldLight.gameObject.activeSelf);
        }
    }

    void TeleportPlayerRandom()
    {
        //player.transform.position = new Vector3(Random.Range(minX, maxX),
        //                                        Random.Range(minY, maxY),
        //                                        Random.Range(minZ, maxZ));
    }

}
