using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Enemy;
    public const float ENEMY_SPAWN_TIME = 1f;
    private float enemySpawnCountdown = ENEMY_SPAWN_TIME;

    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;

    Vector2 generateRandomSpawnPosition() {
        return new Vector2(Random.Range(XMin, XMax), Random.Range(YMin, YMax));
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawnCountdown -= Time.deltaTime;
        if (enemySpawnCountdown <= 0) {
            GameObject newEnemy = Instantiate(Enemy);
            enemySpawnCountdown = ENEMY_SPAWN_TIME;
            newEnemy.transform.SetPositionAndRotation(
                generateRandomSpawnPosition(),
                new Quaternion());
        }
    }
}
