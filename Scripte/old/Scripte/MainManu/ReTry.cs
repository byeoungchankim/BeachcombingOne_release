using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ReTry : MonoBehaviour
{
    public string targetSceneName;

    // ��ư Ŭ�� �̺�Ʈ�� ����� �޼���
    public void LoadTargetScene()
    {
        // targetSceneName�� ������ ������ �̵�
        SceneManager.LoadScene(targetSceneName);
    }
}
