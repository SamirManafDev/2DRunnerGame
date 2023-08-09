using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    void Start()
    {
        foreach (Transform item in transform)
        {
            if (Random.value > 0.4f)
            {
                item.gameObject.SetActive(true);
            }
        }
    }
}
