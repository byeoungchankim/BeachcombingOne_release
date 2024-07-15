using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flsh : MonoBehaviour
{
    public float moveSpeed = 2f;
    private int scorePenalty = 100;
    private int diescorePenalty = 1000;
    public float leftDestination = -4.92f;
    public float rightDestination = 4.92f;
    public int touchCount = 0;
    public ParticleSystem particleEffect;




    private void Update()
    {
        // 왼쪽 또는 오른쪽으로 이동
        float direction = (leftDestination < rightDestination) ? -1f : 1f;
        transform.Translate(Vector3.right * direction * Time.deltaTime * moveSpeed);

        // 특정 x 좌표에 도달하면 회전
        if ((direction < 0 && transform.position.x <= leftDestination) ||
            (direction > 0 && transform.position.x >= rightDestination))
        {
            RotateFish();
        }

        // 물고기를 위아래로 움직이기
        float newY = Mathf.PingPong(Time.time * moveSpeed, 5) - 0.0001f; // 4는 물고기의 움직임 범위
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void RotateFish()
    {
        // 특정 x 좌표에 도달하면 180도 회전
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void OnMouseDown()
    {
        if (touchCount < 3)
        {

            GameManager.Instance.AddScore(-scorePenalty);
            CreateParticleEffect();


            touchCount++;

            // 만약 touchCount가 5가 되면 다른 동작 수행 가능
            if (touchCount == 3)
            { 
            // 터치 시 점수 감소
            GameManager.Instance.AddScore(-diescorePenalty);
                PerformAdditionalAction();


            // 물고기 파괴
                Destroy(gameObject);
            }
        }
    }
    private void CreateParticleEffect()
    {
        if (particleEffect != null)
        {
            // 파티클 생성
            Instantiate(particleEffect, transform.position, Quaternion.identity);
        }
    }

    private void PerformAdditionalAction()
    {
        // 추가 동작 로직을 여기에 추가
    }

}