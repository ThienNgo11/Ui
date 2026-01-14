using UnityEngine;
[System.Serializable]
public class SpinProgressData
{
    [SerializeField]
    private int currentSpinTurn;
    [SerializeField]
    private int targetSpinTurn;

    public int getCurrentSpinTurn => currentSpinTurn;
    public void setCurrentSpinTurn(int n) => currentSpinTurn += n;
    public int getTargetSpinTurn => targetSpinTurn;
}
