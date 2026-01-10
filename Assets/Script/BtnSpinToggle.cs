using UnityEngine;
using UnityEngine.UI;

public class BtnSpinToggle : MonoBehaviour
{
    public Image tabButtonSpin;
    public Sprite nomarlSpin;
    public Sprite vipSpin;
    public Image frameTitle;
    public Sprite nomarlSpin1;
    public Sprite vipSpin1;
    public GameObject SpinNormal;
    public GameObject SpinVIP;

    bool isNomarl = true;

    private void Start()
    {
        updateSprite();
    }

    public void setState()
    {
        isNomarl = !isNomarl;
        updateSprite();
        if(isNomarl == true)
        {
            SpinVIP.SetActive(false);
            SpinNormal.SetActive(true);
        }
        else
        {
            SpinNormal.SetActive(false);
            SpinVIP.SetActive(true);
        }
    }

    void updateSprite()
    {
        if (tabButtonSpin == null) return;
        tabButtonSpin.sprite = isNomarl ? nomarlSpin : vipSpin;
        frameTitle.sprite = isNomarl ? nomarlSpin1 : vipSpin1;
    }
}
