using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashWave : MonoBehaviour
{
    public float floatSpeed = 1.0f; // 떠다니는 속도
    public float rotationSpeed = 50.0f; // 회전 속도

    void Update()
    {
        // 떠다니는 움직임 구현
        float yOffset = Mathf.Sin(Time.time * floatSpeed) * 0.5f;
        //transform.position = new Vector3(transform.position.x, yOffset, transform.position.z);

        // 회전 구현
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        // 물리 엔진 효과 구현 (Rigidbody 필요)
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 randomForce = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        rb.AddForce(randomForce, ForceMode.Force);
    }
}