using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 물고기의 이동 속도
    private Rigidbody rb; // Rigidbody 컴포넌트 참조 변수
    public Animator animator; // 애니메이터 컴포넌트 참조 변수

    void Start()
    {
        // Rigidbody 컴포넌트 가져오기
        rb = GetComponent<Rigidbody>();
        // Animator 컴포넌트 가져오기
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 사용자 입력 받기
        float verticalInput = Input.GetAxis("Vertical");

        // 움직임 적용
        Vector3 moveDirection = transform.forward * verticalInput * moveSpeed;
        rb.velocity = moveDirection;

        // 이동 속도에 따라 애니메이션 재생
        if (verticalInput != 0)
        {
            // Swim 애니메이션 재생
            animator.SetBool("IsSwimming", true);
        }
        else
        {
            // Idle 애니메이션 재생
            animator.SetBool("IsSwimming", false);
        }
    }
}