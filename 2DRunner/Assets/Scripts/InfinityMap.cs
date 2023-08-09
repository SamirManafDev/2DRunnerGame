using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityMap : MonoBehaviour
{
    [SerializeField] private Vector3 offset;
    [SerializeField] private Transform map;
    [SerializeField] private Transform lastMap;

    void Start()
    {
        StartCoroutine(SpawnMap());
        Destroy(gameObject, 100f);
    }

    private IEnumerator SpawnMap()
    {
        yield return new WaitForSeconds(3);
        lastMap = Instantiate(map, lastMap.position + offset, Quaternion.identity);
        StartCoroutine(SpawnMap());
    }
}
