using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject[] coins;

    private void OnEnable()
    {
        if (!(obstacles == null))
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
        }

        if (!(coins == null))
        {
            foreach (GameObject coin in coins)
            {
                coin.SetActive(true);
            }
        }
    }
}