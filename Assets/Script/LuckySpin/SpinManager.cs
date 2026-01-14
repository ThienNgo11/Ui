using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class SpinManager : MonoBehaviour
{
    public static SpinManager Instance { get; private set; }

    public System.Action<int, int> OnSpinProgressChange;
    [SerializeField] private SpinProgressData progress;
    [SerializeField] private Transform Btn;
    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        OnSpinProgressChange?.Invoke(progress.getCurrentSpinTurn, progress.getTargetSpinTurn);
    }

    public void ExecuteSpin()
    {
        if(progress.getCurrentSpinTurn == progress.getTargetSpinTurn)
        {
            progress.setCurrentSpinTurn(-progress.getTargetSpinTurn);
        }
        else
        {
            GameManager.Instance.setCoin(-60);
        }
        progress.setCurrentSpinTurn(1);
        if (progress.getCurrentSpinTurn == progress.getTargetSpinTurn)
        {
            Btn.GetChild(1).gameObject.SetActive(true);
            Btn.GetChild(2).gameObject.SetActive(false);
        }
        else
        {
            Btn.GetChild(1).gameObject.SetActive(false);
            Btn.GetChild(2).gameObject.SetActive(true);
        }
        OnSpinProgressChange?.Invoke(progress.getCurrentSpinTurn, progress.getTargetSpinTurn);
    }
}
