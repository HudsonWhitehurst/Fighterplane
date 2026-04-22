using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject shieldPowerupPrefab;
    public GameObject coinPrefab;

    public TextMeshProUGUI scoreText;
    private int score = 0;


    void Start()
    {
        InvokeRepeating("CreateEnemyOne", 1, 2);
        InvokeRepeating("CreateEnemyTwo", 2.5f, 3.5f);
        InvokeRepeating("CreateShieldPowerup", 5f, 10f);
        InvokeRepeating("CreateCoin", 3f, 6f);
        UpdateScore(0);
    }

    void Update() { }

    void CreateEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }

    void CreateShieldPowerup()
    {
        Instantiate(shieldPowerupPrefab, new Vector3(Random.Range(-9f, 9f), 6.5f, 0), Quaternion.identity);
    }
    void CreateCoin()
    {
        // spawn at random position on screen
        Instantiate(coinPrefab, new Vector3(Random.Range(-8f, 8f), Random.Range(-2f, 2f), 0), Quaternion.identity);
    }

    public void UpdateScore(int points)
    {
        score += points;
        if (scoreText != null)
            scoreText.text = "Score: " + score;
    }
}