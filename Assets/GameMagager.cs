using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;



    [Header("SpawnEnemy")]
    public GameObject Enemy;
    public float SpawnYmin = 10f;
    public float SpawnYmax = 15f;

    public float SpawnXmin = -13f;
    public float SpawnXmax = 13f;

    public float SpawnTime = 0.25f;
    public float currentSpawnTime;


    [Header("Game Status")]
    public int Score;




    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        currentSpawnTime += Time.deltaTime;

        if (currentSpawnTime > SpawnTime)
        {
            Instantiate(Enemy, new Vector2(Random.Range(SpawnXmin, SpawnXmax), Random.Range(SpawnYmin, SpawnXmax)), Quaternion.identity);
            currentSpawnTime = 0f;

        }

    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        Debug.Log("게임 오버!");
        Debug.Log("점수 : " + Score);
    }


}
