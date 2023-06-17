using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graund : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * 3 * Time.deltaTime;
    }
}
