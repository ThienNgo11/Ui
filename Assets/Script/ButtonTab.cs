using TMPro;
using UnityEngine;

public class ButtonTab : MonoBehaviour
{
    public GameObject iconOn;
    public GameObject iconOff;
    public GameObject text;
    public GameObject buttonOnBg;

    public void SetSelected(bool selected)
    {
        iconOn.SetActive(selected);
        buttonOnBg.SetActive(selected);
        text.SetActive(selected);
        iconOff.SetActive(!selected);
    }
}
