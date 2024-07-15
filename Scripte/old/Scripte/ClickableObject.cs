using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ClickableObject : MonoBehaviour
{
    public GameObject bubbleEffectPrefab; // 거품 효과의 프리팹
    public float bubbleEffectDuration = 2f; // 거품 효과 지속 시간
    public FinalScoreManager finalScoreManager;
    public GameManager gameManager;
    public Slider slider; // 해당 스크립트에서 사용할 Slider를 Inspector에서 연결해주세요.

    private bool destroyed = false;
    public float sliderMultiplier = 10f; // 이 값을 조절하여 slider.value의 증가 속도를 조절할 수 있습니다.

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !destroyed) // 마우스 왼쪽 버튼이 클릭되었는지 확인
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    // 거품 효과 생성
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
            slider.value += Time.deltaTime * sliderMultiplier; // sliderMultiplier로 조절
            yield return null;
        }

        // Slider가 1에 도달했을 때 수행할 추가 로직 작성
        if (finalScoreManager != null && GameObject.FindGameObjectsWithTag("Trash").Length == 0)
        {
            finalScoreManager.ShowFinalScore(gameManager.GetScore());
        }

        yield break;
    }
}