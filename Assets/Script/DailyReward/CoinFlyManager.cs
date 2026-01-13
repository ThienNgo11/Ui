using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CoinFlyManager : MonoBehaviour
{
    public static CoinFlyManager Instance;

    [SerializeField] private GameObject xuPrefab;
    [SerializeField] private Transform dichDen;
    [SerializeField] private Transform canvas;
    [SerializeField] private float thoiGianBay = 1.0f;

    [SerializeField] private int soLuong = 20;

    private List<GameObject> danhSachXU = new List<GameObject>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        sinhXu();
    }

    private void sinhXu()
    {
        for (int i = 0; i < soLuong; i++)
        {
            taoTungXuMot();
        }
    }

    private GameObject taoTungXuMot()
    {
        GameObject xu = Instantiate(xuPrefab, canvas);
        xu.SetActive(false); 
        danhSachXU.Add(xu);
        return xu;
    }

    private GameObject layXuTuDanhSach()
    {
        foreach (GameObject xu in danhSachXU)
        {
            if (!xu.activeInHierarchy)
            {
                return xu; 
            }
        }

        return taoTungXuMot();
    }

    public void StartCoinAnimation(Vector3 startPosition, int amount = 10)
    {
        StartCoroutine(SpawnCoinsRoutine(startPosition, amount));
    }

    private IEnumerator SpawnCoinsRoutine(Vector3 diemDau, int soLuongLay)
    {
        for (int i = 0; i < soLuongLay; i++)
        {
            GameObject xu = layXuTuDanhSach();
            xu.transform.position = diemDau;
            xu.transform.localScale = Vector3.one; 
            xu.SetActive(true);

            float x = Random.Range(-100f, 100f);
            float y = Random.Range(-100f, 100f);
            Vector3 r = diemDau + new Vector3(x, y, 0);

            StartCoroutine(diChuyenXu(xu.transform, r, dichDen.position));

            yield return new WaitForSeconds(0.05f);
        }
    }

    private IEnumerator diChuyenXu(Transform xu, Vector3 diemDau, Vector3 diemKet)
    {
        float thoiGianDaBay = 0;

        while (thoiGianDaBay < 0.3f)
        {
            thoiGianDaBay += Time.deltaTime;
            xu.position = Vector3.Lerp(xu.position, diemDau, thoiGianDaBay);
            yield return null;
        }

        thoiGianDaBay = 0;
        Vector3 currentPos = xu.position;
        while (thoiGianDaBay < thoiGianBay)
        {
            thoiGianDaBay += Time.deltaTime;
            float t = thoiGianDaBay / thoiGianBay;
            xu.position = Vector3.Lerp(currentPos, diemKet, t * t);
            yield return null;
        }

        StartCoroutine(hieuUngDich(dichDen));

        xu.gameObject.SetActive(false);
    }

    private IEnumerator hieuUngDich(Transform dichDen)
    {
        if (dichDen == null) yield break;

        dichDen.localScale = Vector3.one * 1.2f;
        yield return new WaitForSeconds(0.1f);
        dichDen.localScale = Vector3.one;
    }
}