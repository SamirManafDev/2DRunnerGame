using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thorn : MonoBehaviour
{
    void Start()
    {
        foreach (Transform item in transform)
        {
            if (Random.value > 0.8f)
            {
                item.gameObject.SetActive(true);
            }
        }
    }
}
