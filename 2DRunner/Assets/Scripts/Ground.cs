using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{

    void Update()
    {
        transform.position += new Vector3(-1, 0, 0) * 7 * Time.deltaTime;
    }
}
