using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public GameObject FloorThickPrefab2;

    public float respawnTime = 1.0f;
    public float respawnTime2 = 1.0f;
    public float levelSpeed = 0.5f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
        StartCoroutine(FloorTile2Wave());
        
    }
    private void spawnFloorTiles()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2( Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
        a.transform.localScale = new Vector2 (Random.Range(0.25f,0.5f), 0.04f);
        a.GetComponent<Platforms>().speed *= levelSpeed;
    }

    private void spawnFloorTiles2()
    {
        GameObject b = Instantiate(FloorThickPrefab2) as GameObject;
        b.transform.position = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 1.5f);
        b.transform.localScale = new Vector2(Random.Range(0.4f, 0.8f), 0.12f);
        b.GetComponent<Platforms>().speed *= levelSpeed;
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
}
