using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ������� �̵� �ӵ�
    private Rigidbody rb; // Rigidbody ������Ʈ ���� ����
    public Animator animator; // �ִϸ����� ������Ʈ ���� ����

    void Start()
    {
        // Rigidbody ������Ʈ ��������
        rb = GetComponent<Rigidbody>();
        // Animator ������Ʈ ��������
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // ����� �Է� �ޱ�
        float verticalInput = Input.GetAxis("Vertical");

        // ������ ����
        Vector3 moveDirection = transform.forward * verticalInput * moveSpeed;
        rb.velocity = moveDirection;

        // �̵� �ӵ��� ���� �ִϸ��̼� ���
        if (verticalInput != 0)
        {
            // Swim �ִϸ��̼� ���
            animator.SetBool("IsSwimming", true);
        }
        else
        {
            // Idle �ִϸ��̼� ���
            animator.SetBool("IsSwimming", false);
        }
    }
}