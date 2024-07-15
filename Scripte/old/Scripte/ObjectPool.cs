using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public int poolSize = 10;

    private List<GameObject> objectPool;

    void Start()
    {
        InitializeObjectPool();
    }

    void InitializeObjectPool()
    {
        objectPool = new List<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(prefab, Vector3.zero, Quaternion.identity);
            obj.SetActive(false);
            objectPool.Add(obj);
        }
    }

    public GameObject SpawnFromPool(Vector3 position, Quaternion rotation)
    {
        foreach (GameObject obj in objectPool)
        {
            if (!obj.activeInHierarchy)
            {
                obj.transform.position = position;
                obj.transform.rotation = rotation;
                obj.SetActive(true);
                return obj;
            }
        }

        // 풀에 사용 가능한 오브젝트가 없을 경우 새로 생성
        GameObject newObj = Instantiate(prefab, position, rotation);
        objectPool.Add(newObj);
        return newObj;
    }
}
