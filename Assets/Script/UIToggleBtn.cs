using UnityEngine;

public class BtnSettingUIController : MonoBehaviour
{
    public GameObject stateOff;
    bool isOn;
    private void Start()
    {
        isOn = true;
    }
    public void toggleBtn()
    {
        stateOff.SetActive(isOn);
        isOn = !isOn;
    }
}
