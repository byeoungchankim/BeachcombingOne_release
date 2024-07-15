using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainManu : MonoBehaviour
{
    public string targetSceneName;

    // 버튼 클릭 이벤트에 연결될 메서드
    public void LoadTargetScene()
    {
        // targetSceneName에 설정된 씬으로 이동
        SceneManager.LoadScene(targetSceneName);
    }
}
