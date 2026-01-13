using UnityEngine;
[CreateAssetMenu(fileName = "NewReward", menuName = "Rewards/GoldenPass")]
public class RewardGoldenPass : ScriptableObject
{
    public int levelIndex;
    public int expRequired;

    [Header("Noraml")]
    public Sprite IconNormal;
    public int AmountNormal;

    [Header("Vip")]
    public Sprite IconVip;
    public int AmountVip;

}
