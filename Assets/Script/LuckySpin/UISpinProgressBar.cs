using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISpinProgressBar : MonoBehaviour
{
    public Slider progressSlider;
    public TextMeshProUGUI progressText;
    private void Start()
    {
        SpinManager.Instance.OnSpinProgressChange += UpdateUI;
    }

    private void OnDisable()
    {
        SpinManager.Instance.OnSpinProgressChange -= UpdateUI;
    }

    public void UpdateUI(int current, int target)
    {
        progressSlider.maxValue = target;
        progressSlider.value = current;
        progressText.text = $"{current}/{target}";
    }
}
