using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] blockPrefab = null;
    [SerializeField] float numbOfblocksInGroup = 0f;
    [SerializeField] float maxGap = 5f;
    [SerializeField] float maxHeightDef = 1f;

    bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (triggered)
        {
            return;
        }
        triggered = true;
        GameObject newBlock = Instantiate(blockPrefab[Random.Range(0, blockPrefab.Length)],
                                            transform.position + new Vector3(numbOfblocksInGroup + Random.Range(0, maxGap),
                                                                                Random.Range(-maxHeightDef, maxHeightDef),
                                                                                0f),
                                            Quaternion.identity);

    }

}
