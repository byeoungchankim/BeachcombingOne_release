using UnityEngine;
using UnityEngine.UI;

public class ClearBar : MonoBehaviour
{
    public Slider slider;
    public float fillSpeed = 0.1f; // 초당 채워지는 속도

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
            // Slider가 1에 도달했을 때 수행할 추가 로직 작성
            Debug.Log("Slider filled!");
        }
    }
}