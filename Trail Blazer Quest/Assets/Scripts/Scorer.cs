using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scorer : MonoBehaviour
{
    [SerializeField] GameObject player = null;

    TMP_Text scorer = null;

    private void Start()
    {
        scorer = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        int distance = (int)player.transform.position.x;
        scorer.text = distance.ToString();
    }
}
