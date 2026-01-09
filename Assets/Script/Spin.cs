using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Collections;
using System.ComponentModel;
using System.Collections.Generic;

[System.Serializable] 
public class RewardData
{
    public Sprite vatPham;
    public string soLuong;
    public float tyLeRroi;  
}

public class Spin : MonoBehaviour
{
    public List<RewardData> DanhSachVatPham;

    public int SoVatPham = 8;
    public float ThoiGianQuay;
    public float SoVongSeQuay;

    private const float TRON = 360.0f;
    private float gocTrenMotVatPham;

    public Transform TuiVatPham;
    private float thoiGianHienTai;

    public AnimationCurve curve;
    private void Start()
    {
        gocTrenMotVatPham = TRON / SoVatPham;
        setPositionItem();
    }

    IEnumerator TurnTheWheel()
    {
        float gocBanDau = transform.eulerAngles.z;
        thoiGianHienTai = 0;
        int ketQuaRandom = getRandomNumberByChance();
        Debug.Log("So thu tu" + ketQuaRandom);

        float tongGocSeQuay = TRON * SoVongSeQuay + ketQuaRandom * gocTrenMotVatPham - gocBanDau;
        while(thoiGianHienTai < ThoiGianQuay)
        {
            yield return new WaitForEndOfFrame();
            thoiGianHienTai += Time.deltaTime;
            float gocDaQuay = tongGocSeQuay * curve.Evaluate(thoiGianHienTai/ThoiGianQuay);
            this.transform.eulerAngles = new Vector3(0, 0, gocDaQuay + gocBanDau);
        }
    }
    [ContextMenu("Turn")]
    public void DoTurnTheWheel()
    {
        StartCoroutine(TurnTheWheel());
    }

    void setPositionItem()
    {
        for (int i = 0; i < TuiVatPham.childCount; i++)
        {
            TuiVatPham.GetChild(i).eulerAngles = new Vector3(0, 0, -gocTrenMotVatPham * i);
            TuiVatPham.GetChild(i).GetComponent<Image>().sprite = DanhSachVatPham[i].vatPham;
            TuiVatPham.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = DanhSachVatPham[i].soLuong.ToString();

        }
    }

    int getRandomNumberByChance()
    {
        float tongTrongSo = 0;
        foreach (var item in DanhSachVatPham)
        {
            tongTrongSo += item.tyLeRroi;
        }
        float indexRandom = Random.Range(0, tongTrongSo);
        for (int i = 0; i < DanhSachVatPham.Count; i++)
        {
            if(indexRandom < DanhSachVatPham[i].tyLeRroi)
            {
                return i;
            }
            else
            {
                indexRandom -= DanhSachVatPham [i].tyLeRroi;
            }
        }
        return DanhSachVatPham.Count - 1;
    }
}
