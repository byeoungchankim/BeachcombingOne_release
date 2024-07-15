using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    public GameObject spawnPointPrefab; // ���� ����Ʈ�� ����� ������
    public Transform[] spawnPoints; // ���� ��ġ�� ������ �迭

    private bool[] spawnPointOccupied; // �� ��ġ�� ���� ���θ� �����ϴ� �迭

    private void Start()
    {
        if (spawnPoints.Length > 0)
        {
            spawnPointOccupied = new bool[spawnPoints.Length];
            // Ÿ�̸� ����
            InvokeRepeating("SpawnPoint", 0f, 3f);
        }
        else
        {
            Debug.LogError("No spawn points available.");
        }
    }

    private void SpawnPoint()
    {
        // �� ��ġ���� ���� ����Ʈ ����
        int emptyIndex = GetEmptySpawnPointIndex();
        if (emptyIndex != -1)
        {
            spawnPointOccupied[emptyIndex] = true; // ��ġ ���� ���� ������Ʈ
            GameObject spawnPoint = Instantiate(spawnPointPrefab, spawnPoints[emptyIndex].position, Quaternion.identity);
            // ������ ���� ����Ʈ�� ���ϴ� �������� ����
            // ��: ������ ����Ʈ�� � �۾��� �����ϰų� �ٸ� ������Ʈ�� �߰��� �� ����
        }
    }

    private int GetEmptySpawnPointIndex()
    {
        // �� ��ġ�� �ε����� ��ȯ, ��� ��ġ�� �����Ǹ� -1 ��ȯ
        for (int i = 0; i < spawnPointOccupied.Length; i++)
        {
            if (!spawnPointOccupied[i])
            {
                return i;
            }
        }
        return -1;
    }
}