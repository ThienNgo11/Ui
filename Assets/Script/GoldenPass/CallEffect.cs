using UnityEngine;

public class CallEffect : MonoBehaviour
{
    public GameObject Done;
    public void call()
    {
        if (CoinFlyManager.Instance != null)
        {
            CoinFlyManager.Instance.StartCoinAnimation(gameObject.transform.position, 10);
            Done.SetActive(true);
            gameObject.SetActive(false);
        }
        if(GameManager.Instance != null)
        {
            GameManager.Instance.setCoin(50);
        }
    }
}
