using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] Sprite[] sprites;
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
        enemy.transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4f, 4f));
    }
}