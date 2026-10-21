using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.instance.AddScore(10);
            gameObject.SetActive(false);
            
        }
    }
}
