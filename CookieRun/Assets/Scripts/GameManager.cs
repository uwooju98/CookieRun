using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static float MaxHp { get; private set; }

    public bool isGameOver = false;
    public TMP_Text scoreText;
    public TMP_Text HpText;
    public GameObject gameOverUI;
    private int score = 0;




    private void Awake()
    {
        MaxHp = 100f;

        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }


        MaxHp = Mathf.Clamp(MaxHp - Time.deltaTime * 5, 0, 100);
        HpText.text = $"HP : {MaxHp:F0}";
    }

    public void AddScore(int newScore)
    {
        if (!isGameOver)
        {
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }

    public void AddHp(float newHp)
    {
        if (!isGameOver)
        {
            MaxHp = Mathf.Clamp(MaxHp + newHp, 0, 100);
            HpText.text = $"HP : {MaxHp:F0}";
        }
    }

    public bool IsDie()
    {
        if (MaxHp <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    public void OnPlayerDead()
    {
        isGameOver = true;
        gameOverUI.SetActive(true);
    }

}
