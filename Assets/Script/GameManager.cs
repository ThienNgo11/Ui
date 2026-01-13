using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public int expPlayer { get; private set; }
    private void Awake()
    {
        expPlayer = 5;
        Instance = this;
    }
}
