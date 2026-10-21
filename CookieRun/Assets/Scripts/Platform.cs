using UnityEngine;

public class UpPlatform : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] coins;

    private void OnEnable()
    {
        for (int i = 0; i < obstacles.Length; i++)
        {
            if (Random.Range(0, 3) == 0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }

        foreach (GameObject coin in coins)
        {
            coin.SetActive(true);
        }
    }
}