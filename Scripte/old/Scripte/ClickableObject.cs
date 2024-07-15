using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickableObject : MonoBehaviour
{
    public GameObject bubbleEffectPrefab; // ��ǰ ȿ���� ������
    public float bubbleEffectDuration = 2f; // ��ǰ ȿ�� ���� �ð�
    public FinalScoreManager finalScoreManager;
    public GameManager gameManager;
    public Slider slider; // �ش� ��ũ��Ʈ���� ����� Slider�� Inspector���� �������ּ���.

    private bool destroyed = false;
    public float sliderMultiplier = 10f; // �� ���� �����Ͽ� slider.value�� ���� �ӵ��� ������ �� �ֽ��ϴ�.

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !destroyed) // ���콺 ���� ��ư�� Ŭ���Ǿ����� Ȯ��
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    // ��ǰ ȿ�� ����
                    GameObject bubbleEffect = Instantiate(bubbleEffectPrefab, transform.position, Quaternion.identity);
                    Destroy(bubbleEffect, bubbleEffectDuration);

                    if (gameManager != null)
                    {
                        gameManager.GetScore();
                    }

                    destroyed = true;
                    StartCoroutine(IncreaseSliderOverTime());
                    Destroy(this.gameObject);
                }
            }
        }
    }

    IEnumerator IncreaseSliderOverTime()
    {
        float elapsedTime = 0f;

        while (elapsedTime < bubbleEffectDuration)
        {
            elapsedTime += Time.deltaTime;
            slider.value += Time.deltaTime * sliderMultiplier; // sliderMultiplier�� ����
            yield return null;
        }

        // Slider�� 1�� �������� �� ������ �߰� ���� �ۼ�
        if (finalScoreManager != null && GameObject.FindGameObjectsWithTag("Trash").Length == 0)
        {
            finalScoreManager.ShowFinalScore(gameManager.GetScore());
        }

        yield break;
    }
}