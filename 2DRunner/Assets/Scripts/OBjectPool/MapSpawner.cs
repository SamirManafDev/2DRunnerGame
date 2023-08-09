using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSpawner : MonoBehaviour
{
    private ObjectPool pool;

    private void Start()
    {
        pool = FindObjectOfType<ObjectPool>();
        StartCoroutine(SpawnMap());

    }



    IEnumerator SpawnMap()
    {
        while (true)
        {
            GameObject map = pool.GetObjectFromPool();

            map.transform.position = new Vector3(0, -10.5f, 0);
            yield return new WaitForSeconds(4);

        }
    }
}
