using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DailyReward : MonoBehaviour
{
    [SerializeField]
    public List<GameObject> ListItem;

    public int SoNgay = 7;
    private int ngayHienTai = 1;
    public Sprite HomNay; //xanh lá
    public Sprite KhongPhaiHomNay; //xanh nươc biển
    public GameObject BlockLayer;

    public void PassDay()
    {
        ListItem[ngayHienTai-1].GetComponent<Image>().sprite = KhongPhaiHomNay;
        Transform deactiveBTN = ListItem[ngayHienTai - 1].transform.Find("deactivateBtn");
        if(deactiveBTN != null)
        {
            deactiveBTN.gameObject.SetActive(true);
        }
        if (CoinFlyManager.Instance != null)
        {
            CoinFlyManager.Instance.StartCoinAnimation(ListItem[ngayHienTai - 1].transform.position, 10);
        }
        ngayHienTai++;
        ListItem[ngayHienTai-1].GetComponent<Image>().sprite = HomNay;
    }

    
}
