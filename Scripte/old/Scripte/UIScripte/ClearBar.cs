using UnityEngine;
using UnityEngine.UI;

public class ClearBar : MonoBehaviour
{
    public Slider slider;
    public float fillSpeed = 0.1f; // �ʴ� ä������ �ӵ�

    void Update()
    {
        if (slider != null)
        {
            FillSliderOverTime();
        }
    }

    void FillSliderOverTime()
    {
        slider.value = Mathf.MoveTowards(slider.value, 1f, fillSpeed * Time.deltaTime);

        if (slider.value == 1f)
        {
            // Slider�� 1�� �������� �� ������ �߰� ���� �ۼ�
            Debug.Log("Slider filled!");
        }
    }
}