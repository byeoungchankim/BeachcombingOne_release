using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashWave : MonoBehaviour
{
    public float floatSpeed = 1.0f; // ���ٴϴ� �ӵ�
    public float rotationSpeed = 50.0f; // ȸ�� �ӵ�

    void Update()
    {
        // ���ٴϴ� ������ ����
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * 0.5f;
        //transform.position = new Vector3(transform.position.x, yOffset, transform.position.z);

        // ȸ�� ����
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // ���� ���� ȿ�� ���� (Rigidbody �ʿ�)
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 randomForce = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        rb.AddForce(randomForce, ForceMode.Force);
    }
}