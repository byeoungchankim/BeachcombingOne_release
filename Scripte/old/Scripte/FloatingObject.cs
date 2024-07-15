using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float floatSpeed = 1.0f;  // ��ü�� ��鸮�� �ӵ�
    public float floatAmount = 0.5f; // ��ü�� �ִ� ��鸲 ����

    private Vector3 startPos; // �ʱ� ��ġ

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        // Sin �Լ��� ����Ͽ� �¿�� ��鸲 ȿ�� ����
        float floatOffset = Mathf.Sin(Time.time * floatSpeed) * floatAmount;

        // ���� ��ġ�� ��鸲 ȿ�� �߰�
        Vector3 newPosition = startPos + new Vector3(floatOffset, 0f, 0f);
        transform.position = newPosition;
    }
}
