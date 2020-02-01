using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloor : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float respawnTime = 1.0f;
    public float levelSpeed = 1f;
    private Vector2 screenBounds;

    // Use this for initialization
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }
    private void spawnFloorTiles()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2( Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y * 2);
        a.transform.localScale = new Vector2 (Random.Range(0.2f,0.45f), 0.03330469f);
        a.GetComponent<Platforms>().speed *= levelSpeed;
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnFloorTiles();
        }
    }
}
