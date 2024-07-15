using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject objectPrefab; // 스폰할 오브젝트 프리팹
    public float spawnChance = 0.5f; // 오브젝트가 스폰될 확률
    public float spawnInterval = 2f; // 스폰 간격
    public float speed = 5f; // 오브젝트의 이동 속도
    public float destroyDelay = 10f; // 스폰된 오브젝트를 파괴할 지연 시간
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            timer = 0f;
            float randomValue = Random.value;
            if (randomValue <= spawnChance)
            {
                SpawnObject();
            }
        }
    }

    void SpawnObject()
    {
        // 스폰 포인트에서 오브젝트를 스폰
        GameObject spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.Euler(0f, -90f, 0f)); // 회전값을 -90으로 고정
        // 스폰된 오브젝트를 왼쪽으로 이동
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = -transform.right * speed; // 왼쪽 방향으로 이동
        }

        // 일정 시간이 지난 후에 파괴
        Destroy(spawnedObject, destroyDelay);
    }
}