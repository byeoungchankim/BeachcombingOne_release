using System.Collections;
using UnityEngine;

public class GameStartCountDown : MonoBehaviour
{
    private float Timer = 0f;
    public GameObject IMG_tutorial; // Ʃ�丮�� �̹���
    public GameObject Num_A; //1��
    public GameObject Num_B; //2��
    public GameObject Num_C; //3��
    public GameObject NUM_GO; // ���۾�����


    // Start is called before the first frame update
    void Start()
    {
        Timer = 1f;
        IMG_tutorial.SetActive(false);
        Num_A.SetActive(false);
        Num_B.SetActive(false);
        Num_C.SetActive(false);
        NUM_GO.SetActive(false);

        StartCoroutine(StartCountdown());
    }
    IEnumerator StartCountdown()
    {
        yield return new WaitForSeconds(1.0f);

        Time.timeScale = 0.0f; // ������ ����

        yield return new WaitForSeconds(3.0f); // 3�� ���� ���

        Time.timeScale = 1.0f;
        NUM_GO.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 150)
        {
            Timer++;

            if(Timer < 60)
            {
                IMG_tutorial.SetActive(true);
                
            }
            if (Timer < 90)
            {
                IMG_tutorial.SetActive(false);
                Num_C.SetActive(true);
            }
            if (Timer < 120)
            {
                Num_C.SetActive(false);
                Num_B.SetActive(true);
            }
            if (Timer < 150)
            {
                Num_B.SetActive(false);
                Num_A.SetActive(true);
                StartCoroutine(this.LoadingEnd());
                
            }
        }
    }

    IEnumerator LoadingEnd()
    {
        yield return new WaitForSeconds(3.0f);
        NUM_GO.SetActive(false);
    }
}
