using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointManager : MonoBehaviour
{
    public GameObject spawnPointPrefab; // 스폰 포인트로 사용할 프리팹
    public Transform[] spawnPoints; // 여러 위치를 저장할 배열

    private bool[] spawnPointOccupied; // 각 위치의 점유 여부를 저장하는 배열

    private void Start()
    {
        if (spawnPoints.Length > 0)
        {
            spawnPointOccupied = new bool[spawnPoints.Length];
            // 타이머 시작
            InvokeRepeating("SpawnPoint", 0f, 3f);
        }
        else
        {
            Debug.LogError("No spawn points available.");
        }
    }

    private void SpawnPoint()
    {
        // 빈 위치에서 스폰 포인트 생성
        int emptyIndex = GetEmptySpawnPointIndex();
        if (emptyIndex != -1)
        {
            spawnPointOccupied[emptyIndex] = true; // 위치 점유 상태 업데이트
            GameObject spawnPoint = Instantiate(spawnPointPrefab, spawnPoints[emptyIndex].position, Quaternion.identity);
            // 생성된 스폰 포인트를 원하는 로직으로 설정
            // 예: 스폰된 포인트에 어떤 작업을 수행하거나 다른 컴포넌트를 추가할 수 있음
        }
    }

    private int GetEmptySpawnPointIndex()
    {
        // 빈 위치의 인덱스를 반환, 모든 위치가 점유되면 -1 반환
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