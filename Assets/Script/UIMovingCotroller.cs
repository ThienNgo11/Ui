using UnityEngine;

public class UiSettingCotroller : MonoBehaviour
{
    public GameObject settingUI;
    public GameObject luckySpinUI;
    public GameObject blockClick;
    public GameObject shopPopUp;
    public GameObject dailyRewardPopUp;
    public GameObject goldenPassPopUp;
    public GameObject goldenPassFesPopUp;
    public GameObject taskPopUp;
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
    public void OpenGoldenPassUI()
    {
        goldenPassPopUp.SetActive(true);
    }

    public void CloseGoldenPassUI()
    {
        goldenPassPopUp.SetActive(false);
    }
    public void OpenFes()
    {
        goldenPassFesPopUp.SetActive(true);
    }

    public void CloseFes()
    {
        goldenPassFesPopUp.SetActive(false);
    }
    public void OpenTaskPopUp()
    {
        taskPopUp.SetActive(true);
    }

    public void CloseTaskPopUp()
    {
        taskPopUp.SetActive(false);
    }


}
