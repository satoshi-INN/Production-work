using UnityEngine;
using System.Collections;

public class WindGenerator : MonoBehaviour
{
    // WindAUzumaki‚ðˆê’èŠÔŠu‚Å¶¬‚·‚é

    //[SerializeField]‚ÌŽw’è
    [SerializeField] Wind windPrefab;
    [SerializeField] Uzumaki uzumakiPrefab;
    [SerializeField] INZM inzmPrefab;
    [SerializeField] Building buildPrefab;

    // x•bŠÔŠu(Ž©—R)‚Å¶¬‚µ‚½‚¢
    [SerializeField] float spawnTime;

    //ŒÅ’è’l‚ð¶¬
    float waitTimer = 0;
    float spawnInterval = 0;
    int randomGet = 0;

    // Update is called once per frame
    void Update()
    {
        waitTimer += Time.deltaTime;

        if (waitTimer >= spawnTime)
        {
            waitTimer = 0;
            SpawnAll();
        }
    }

    // ¶¬
    void SpawnAll()
    {
        SetRandomSpawnInterval();
    }

    void SetRandomSpawnInterval()
    {
        int randomGet = Random.Range(1, 100);
        int split = randomGet % 5;

        if (randomGet >= 90)
        {
            SpawnEntity();
        }
        else if (split == 0)
        {
            Build();
            Spawn();
        }
        else if (randomGet == 90 || randomGet == 95 || randomGet == 100)
        {
            Build();
            SpawnEntity();
        }
        else if(randomGet == 3)
        {
            InstantDeath();
            Spawn();
        }
        else
        {
            Spawn();
        }
    }

    void Spawn()
    {
        Vector3 cameraPos = Camera.main.transform.position;
        Vector2 randomPos = new Vector2(cameraPos.x + 20.5f, Random.Range(cameraPos.y - 4.5f, cameraPos.y + 4.5f));
        Instantiate(windPrefab, randomPos, transform.rotation);
    }

    void SpawnEntity()
    {
        Vector3 cameraPos = Camera.main.transform.position;
        Vector2 spawnPosition = new Vector2(cameraPos.x + 20.5f, Random.Range(cameraPos.y - 5f, cameraPos.y + -1f));
        Instantiate(uzumakiPrefab, spawnPosition, Quaternion.identity);
    }

    void Build()
    {
        Vector3 cameraPos = Camera.main.transform.position;
        Vector2 spawnPosition = new Vector2(cameraPos.x + 20.5f, cameraPos.y);
        Instantiate(buildPrefab, spawnPosition, Quaternion.identity);
    }

    void InstantDeath()
    {
        Vector3 cameraPos = Camera.main.transform.position;
        Vector2 spawnPosition = new Vector2(cameraPos.x, cameraPos.y);
        Instantiate(inzmPrefab, spawnPosition, Quaternion.identity);
    }
}