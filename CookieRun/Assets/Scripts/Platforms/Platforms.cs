using UnityEngine;

public class Platforms : MonoBehaviour
{

    public GameObject[] platforms;

    private void Awake()
    {
        if (!(platforms == null))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                platforms[Random.Range(0, 5)].SetActive(false);
            }
        }
    }


    private void OnEnable()
    {
        if (!(platforms == null))
        {
            platforms[Random.Range(0, 5)].SetActive(true);
        }
    }

    private void OnDisable()
    {
        if (!(platforms == null))
        {
            for (int i = 0; i < platforms.Length; i++)
            {
                platforms[i].SetActive(false);
            }
        }
    }
}

