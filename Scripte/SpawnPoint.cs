using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject objectPrefab; // ������ ������Ʈ ������
    public float spawnChance = 0.5f; // ������Ʈ�� ������ Ȯ��
    public float spawnInterval = 2f; // ���� ����
    public float speed = 5f; // ������Ʈ�� �̵� �ӵ�
    public float destroyDelay = 10f; // ������ ������Ʈ�� �ı��� ���� �ð�
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
        // ���� ����Ʈ���� ������Ʈ�� ����
        GameObject spawnedObject = Instantiate(objectPrefab, transform.position, Quaternion.Euler(0f, -90f, 0f)); // ȸ������ -90���� ����
        // ������ ������Ʈ�� �������� �̵�
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = -transform.right * speed; // ���� �������� �̵�
        }

        // ���� �ð��� ���� �Ŀ� �ı�
        Destroy(spawnedObject, destroyDelay);
    }
}