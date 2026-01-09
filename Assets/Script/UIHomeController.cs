using UnityEditor.Rendering;
using UnityEngine;

public class UIHomeController : MonoBehaviour
{
    [Header("Button")]
    public ButtonTab homeActive;
    public ButtonTab shopActive;
    public ButtonTab leagueActive;

    [Header("Popup")]
    public GameObject shopPopUp;

    [Header("BlockClick")]
    public GameObject blockClick;

    public void ShowHome()
    {
        homeActive.SetSelected(true);
        shopActive.SetSelected(false);
        leagueActive.SetSelected(false);
    }
    public void ShowShop()
    {
        homeActive.SetSelected(false);
        shopActive.SetSelected(true);
        leagueActive.SetSelected(false);
    }
    public void ShowRank()
    {
        homeActive.SetSelected(false);
        shopActive.SetSelected(false);
        leagueActive.SetSelected(true);
    }
}
