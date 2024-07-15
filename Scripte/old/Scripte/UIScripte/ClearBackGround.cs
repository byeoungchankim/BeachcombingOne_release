using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearBackGround : MonoBehaviour
{
    public Slider slider; // 클리어를 판단할 슬라이더를 Inspector에서 연결해주세요.
    public GameObject gameClearBackgroundUI; // 클리어 백그라운드 UI 프리팹을 Inspector에서 연결해주세요.

    void Update()
    {
        // 슬라이더 값이 1이 되었을 때 GameClearBackground UI를 활성화
        if (slider != null && slider.value >= 1.0f && gameClearBackgroundUI != null)
        {
            gameClearBackgroundUI.SetActive(true);
        }
    }
}