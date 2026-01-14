using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static Action<int, int> OnCoinChange;
    public int levelPlayer { get; private set; }
    private int coinPlayer;
    private int starPlayer;

    private void Awake()
    {
        coinPlayer = 500;
        starPlayer = 20;
        levelPlayer = 5;
        Instance = this;
    }

    public void setCoin(int coin)
    {
        coinPlayer += coin;
        OnCoinChange?.Invoke(coinPlayer, starPlayer);
    }

    public void setStar(int star)
    {
        starPlayer += star;
        OnCoinChange?.Invoke(starPlayer, starPlayer);
    }

    public int getCoin() => coinPlayer;
    public int getStar() => starPlayer;
}
