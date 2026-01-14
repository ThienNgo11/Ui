using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UICurrentDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private TextMeshProUGUI starText;

    public void OnEnable()
    {
        GameManager.OnCoinChange += UpdateCoinUi;
    }

    public void OnDisable()
    {
        GameManager.OnCoinChange -= UpdateCoinUi;
    }
    
    private void Start()
    {
        UpdateCoinUi(GameManager.Instance.getCoin(), GameManager.Instance.getStar());
    }

    public void UpdateCoinUi(int coin, int star)
    {
        coinText.text = coin.ToString();
        starText.text = star.ToString();
    }
}
