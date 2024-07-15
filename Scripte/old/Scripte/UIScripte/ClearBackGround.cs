using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearBackGround : MonoBehaviour
{
    public Slider slider; // Ŭ��� �Ǵ��� �����̴��� Inspector���� �������ּ���.
    public GameObject gameClearBackgroundUI; // Ŭ���� ��׶��� UI �������� Inspector���� �������ּ���.

    void Update()
    {
        // �����̴� ���� 1�� �Ǿ��� �� GameClearBackground UI�� Ȱ��ȭ
        if (slider != null && slider.value >= 1.0f && gameClearBackgroundUI != null)
        {
            gameClearBackgroundUI.SetActive(true);
        }
    }
}