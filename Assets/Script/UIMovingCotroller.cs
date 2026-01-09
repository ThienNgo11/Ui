using UnityEngine;

public class UiSettingCotroller : MonoBehaviour
{
    public GameObject settingUI;
    public GameObject luckySpinUI;
    public GameObject blockClick;
    public GameObject shopPopUp;
    public GameObject dailyRewardPopUp;
    public void OpenSettingUI()
    {
        settingUI.SetActive(true);
        blockClick.SetActive(true);
    }

    public void ColoseSettingUI()
    {
        settingUI.SetActive(false);
        blockClick.SetActive(false);
    }
    public void OpenLuckySpinUI()
    {
        luckySpinUI.SetActive(true);
    }

    public void CloseLuckySpinUI()
    {
        luckySpinUI.SetActive(false);
    }
    public void OpenShopPopUpUI()
    {
        shopPopUp.SetActive(true);
    }

    public void CloseShopPopUpUI()
    {
        shopPopUp.SetActive(false);
    }
    public void OpenDailyRewardUI()
    {
        blockClick.SetActive(true);
        dailyRewardPopUp.SetActive(true);
    }

    public void CloseDailyRewardUI()
    {
        dailyRewardPopUp.SetActive(false);
        blockClick.SetActive(false);

    }


}
