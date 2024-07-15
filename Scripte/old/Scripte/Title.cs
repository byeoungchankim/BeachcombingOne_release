using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update

    public string targetSceneName = "YourTargetSceneName";

    // �� �޼���� Start ��ư�� Ŭ���� �� Unity UI���� �ڵ����� ȣ��˴ϴ�.
    public void OnStartButtonClick()
    {
        // targetSceneName�� ������ ������ ��ȯ�մϴ�.
        SceneManager.LoadScene(targetSceneName);
    }
}
