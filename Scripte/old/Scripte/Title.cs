using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update

    public string targetSceneName = "YourTargetSceneName";

    // 이 메서드는 Start 버튼이 클릭될 때 Unity UI에서 자동으로 호출됩니다.
    public void OnStartButtonClick()
    {
        // targetSceneName에 지정된 씬으로 전환합니다.
        SceneManager.LoadScene(targetSceneName);
    }
}
