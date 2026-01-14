using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public static UiManager Instance;
    public Transform CoinUI;
    public Transform StarUI;

    private void Awake()
    {
        Instance = this;
    }
}
