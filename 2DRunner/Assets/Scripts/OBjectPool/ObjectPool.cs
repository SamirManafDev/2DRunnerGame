using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public List<GameObject> prefabs;
    public int poolSize = 10;
    public float creationInterval = 2f;

    private List<GameObject> objectPool;
    private List<GameObject> touchedObjects;
    private float timer;

    private void Start()
    {
        objectPool = new List<GameObject>();
        touchedObjects = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
            obj.SetActive(false);
            objectPool.Add(obj);
        }
    }

    public GameObject GetObjectFromPool()
    {
        foreach (GameObject obj in objectPool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.SetActive(true);
                return obj;
            }
        }

        GameObject newObj = Instantiate(prefabs[Random.Range(0, prefabs.Count)]);
        newObj.SetActive(true);
        objectPool.Add(newObj);
        return newObj;
    }

    public void ReturnObjectToPool(GameObject obj)
    {
        obj.SetActive(false);
    }

}

