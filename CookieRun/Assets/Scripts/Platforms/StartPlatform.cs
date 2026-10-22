using UnityEngine;

public class StartPlatform : MonoBehaviour
{
    private float StartTimer = 3f;

    private void Start()
    {
        Destroy(gameObject, StartTimer);
    }
}
