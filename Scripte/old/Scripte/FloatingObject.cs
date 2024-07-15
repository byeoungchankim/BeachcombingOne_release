using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatSpeed = 1.0f;  // 물체가 흔들리는 속도
    public float floatAmount = 0.5f; // 물체의 최대 흔들림 정도

    private Vector3 startPos; // 초기 위치

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Sin 함수를 사용하여 좌우로 흔들림 효과 생성
        float floatOffset = Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        // 현재 위치에 흔들림 효과 추가
        Vector3 newPosition = startPos + new Vector3(floatOffset, 0f, 0f);
        transform.position = newPosition;
    }
}
