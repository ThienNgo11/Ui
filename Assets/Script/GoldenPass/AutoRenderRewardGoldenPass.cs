using System.Collections.Generic;
using UnityEngine;

public class AutoRenderRewardGoldenPass : MonoBehaviour
{
    [SerializeField] private int AmoutReward = 10;
    [SerializeField] private List<RewardGoldenPass> allReward;

    [SerializeField] private GameObject UnitReward;
    [SerializeField] private Transform contentParent;


    private void Start()
    {
        SpawnRewards(UnitReward);
    }

    void SpawnRewards(GameObject reward)
    {
        foreach (RewardGoldenPass data in  allReward)
        {
            Debug.Log(allReward.Count);
            GameObject newUnitRewar = Instantiate(UnitReward, contentParent);
            RowController controller = newUnitRewar.GetComponent<RowController>();
            if(controller != null)
            {
                controller.SetUpRow(data);
            }
        }
    }
}
