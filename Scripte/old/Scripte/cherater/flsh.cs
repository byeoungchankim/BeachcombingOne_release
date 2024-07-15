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
        // ���� �Ǵ� ���������� �̵�
        float direction = (leftDestination < rightDestination) ? -1f : 1f;
        transform.Translate(Vector3.right * direction * Time.deltaTime * moveSpeed);

        // Ư�� x ��ǥ�� �����ϸ� ȸ��
        if ((direction < 0 && transform.position.x <= leftDestination) ||
            (direction > 0 && transform.position.x >= rightDestination))
        {
            RotateFish();
        }

        // ����⸦ ���Ʒ��� �����̱�
        float newY = Mathf.PingPong(Time.time * moveSpeed, 5) - 0.0001f; // 4�� ������� ������ ����
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }

    private void RotateFish()
    {
        // Ư�� x ��ǥ�� �����ϸ� 180�� ȸ��
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void OnMouseDown()
    {
        if (touchCount < 3)
        {

            GameManager.Instance.AddScore(-scorePenalty);
            CreateParticleEffect();


            touchCount++;

            // ���� touchCount�� 5�� �Ǹ� �ٸ� ���� ���� ����
            if (touchCount == 3)
            { 
            // ��ġ �� ���� ����
            GameManager.Instance.AddScore(-diescorePenalty);
                PerformAdditionalAction();


            // ����� �ı�
                Destroy(gameObject);
            }
        }
    }
    private void CreateParticleEffect()
    {
        if (particleEffect != null)
        {
            // ��ƼŬ ����
            Instantiate(particleEffect, transform.position, Quaternion.identity);
        }
    }

    private void PerformAdditionalAction()
    {
        // �߰� ���� ������ ���⿡ �߰�
    }

}