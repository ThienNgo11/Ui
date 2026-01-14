using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RowController : MonoBehaviour
{
    [Header("UI reference")]
    public TextMeshProUGUI levelText;
    public Image IconNormal;
    public TextMeshProUGUI AmountNormal;
    public Image IconVip;
    public TextMeshProUGUI AmountVip;

    [Header("Interact")]
    public GameObject ClaimBtn;
    public Image Progress;
    public Image DotLevel;
    public GameObject Done;
    public GameObject Lock;
    public Sprite ProgressDone;
    public Sprite DotLevelDone;

    void SetClaim(RewardGoldenPass data)
    {
        if (GameManager.Instance.levelPlayer >= data.expRequired)
        {
            ClaimBtn.SetActive(true);
            Progress.sprite = ProgressDone;
            DotLevel.sprite = DotLevelDone;
            Lock.SetActive(false);
        }
        else return;
    }
    public  void SetUpRow(RewardGoldenPass data)
    {
        levelText.text =  data.levelIndex.ToString();
        IconNormal.sprite = data.IconNormal;
        AmountNormal.text = data.AmountNormal.ToString();
        
        IconVip.sprite = data.IconVip;
        AmountVip.text = data.AmountVip.ToString();
        SetClaim(data);
    }
}
