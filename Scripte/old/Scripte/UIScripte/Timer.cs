using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    float setTime = 10.0f;
    [SerializeField]
    Text countdownText;

    [SerializeField]
    List<GameObject> uiElementsToTurnOff;

    [SerializeField]
    GameObject endingUIObject;

    void Start()
    {
        countdownText.text = setTime.ToString();
    }
    void Update()
    {
        if (setTime > 0)
            setTime -= Time.deltaTime;
        else if (setTime <= 0)
        {
            setTime = 0; // 음수로 가지 않도록 보정

            foreach (GameObject uiElement in uiElementsToTurnOff)
            {
                if (uiElement != null)
                    uiElement.SetActive(false);
            }
            // 원하는 UI를 활성화
            if (endingUIObject != null)
                endingUIObject.SetActive(true);

            // 게임 일시 정지
            Time.timeScale = 0.0f;
        }

        countdownText.text = Mathf.Round(setTime).ToString();
    }
}