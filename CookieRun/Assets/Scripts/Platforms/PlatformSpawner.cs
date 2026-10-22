using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] PlatformPrefabs;
    public int count = 8;

    private float timeBetSpawnMin = 2.2f;
    private float timeBetSpawnMax = 2.5f;

    private float timeBetSpawn;


    private float xPos = 20f;
    private float yPos = -4.5f;

    private GameObject[] platforms;
    private int currentIndex = 0;

    private Vector2 poolPosition = new Vector2(0, -25f);
    private float lastSpawnTime;

    private void Start()
    {
        platforms = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            platforms[i] = Instantiate(PlatformPrefabs[0], poolPosition, Quaternion.identity);
        }

        lastSpawnTime = 0f;
        timeBetSpawn = 0f;
    }

    private void Update()
    {
        if (GameManager.instance.isGameOver)
        {
            return;
        }

        if (Time.time >= lastSpawnTime + timeBetSpawn)
        {
            lastSpawnTime = Time.time;

            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);

            platforms[currentIndex].SetActive(false);
            platforms[currentIndex].SetActive(true);

            platforms[currentIndex].transform.position = new Vector2(xPos, yPos);
            currentIndex++;

            if (currentIndex >= count)
            {
                currentIndex = 0;
            }
        }

    }

}
