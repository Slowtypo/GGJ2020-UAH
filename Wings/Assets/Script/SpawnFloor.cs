using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFloor : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject FloorThickPrefab2;
    public GameObject FloorThickScraps;
    public GameObject TextUpdate;
    public GameObject TextScarpsUpdate;
    public GameObject enemy1;
    public Text textLevelUpdate;

    public float respawnTime = 1.0f;
    public float respawnTime2 = 6.0f;
    public float respawnTimeScraps = 10f;
    public float respawnEnemy = 12f;
    public float levelSpeed = 0.5f;
    private Vector2 screenBounds;
    public int scrapsT = 0;

    bool Trung = false;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
        StartCoroutine(FloorTile2Wave());
        StartCoroutine(FloorTileScrapsWave());
        StartCoroutine(EnemyBallWave());
        levelSpeed = 0.5f;



    }
    private void Update()
    {
        scrapsT = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>().scraps;
        TextScarpsUpdate.GetComponent<Text>().text = "Scraps: " + scrapsT;
        textLevelUpdate.text = "Level:" + (int)levelSpeed;

        if (levelSpeed >= 3f && Trung == false)
        {
            AddLevel();
            Trung = true;
        }
        //else if (levelSpeed > 5f) {
            //TextUpdate.GetComponent<CharacterController2D>().jumpLevel = 6;
        //}

    }

    public void AddLevel ()
    {
        TextUpdate.GetComponent<CharacterController2D>().jumpLevel += 1;
        Debug.Log("weird code activated");
    }
    private void spawnFloorTiles()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2( Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1);
        a.transform.localScale = new Vector2 (Random.Range(0.5f,1.2f), 1.2f);
        a.GetComponent<Platforms>().speed *= levelSpeed;
    }

    private void spawnFloorTiles2()
    {
        GameObject b = Instantiate(FloorThickPrefab2) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1.5f);
        b.transform.localScale = new Vector2(Random.Range(1f, 2f), 1.2f);
        b.GetComponent<Platforms>().speed *= levelSpeed;
    }
    private void spawnFloorTiles3()
    {
        GameObject c = Instantiate(FloorThickScraps) as GameObject;
        c.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1.5f);
        c.transform.localScale = new Vector2(1.0f, 1.0f);
        c.GetComponent<Platforms>().speed *= levelSpeed;
    }

    private void EnemyBall()
    {
        GameObject D = Instantiate(enemy1) as GameObject;
        D.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1.5f);
        D.transform.localScale = new Vector2(4.0f, 4.0f);
        D.GetComponent<Enemy1>().speed1 *= levelSpeed;
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFloorTiles();
        }
    }

    IEnumerator FloorTile2Wave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime2);
            spawnFloorTiles2();
        }
    }

    IEnumerator FloorTileScrapsWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeScraps + (int)Random.Range(1f, 5f));
            spawnFloorTiles3();
        }
    }

    IEnumerator EnemyBallWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTimeScraps + (int)Random.Range(1f, 5f));
            EnemyBall();
        }
    }
}
