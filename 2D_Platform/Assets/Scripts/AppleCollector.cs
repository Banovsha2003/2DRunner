using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AppleCollector : MonoBehaviour
{
    private int apples;
    [SerializeField] private TMP_Text text;
    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy the coin if Object tagged Player comes in contact with it
        if (c2d.CompareTag("Player"))
        {
            //Add coin to counter
            apples++;
            Destroy(gameObject);
            text.text = apples.ToString();
        }
    }
}
