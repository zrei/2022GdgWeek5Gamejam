using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Friend;
    public GameObject Enemy;
    [SerializeField] private float spawnTime;
    private float enemySpawnCountdown;

    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;

    Vector2 generateRandomSpawnPosition() {
        switch (Random.Range(0, 4)) {
            case 0:
                return new Vector2(Random.Range(XMin, XMax), YMax);
            case 1:
                return new Vector2(XMax, Random.Range(YMin, YMax));
            case 2:
                return new Vector2(Random.Range(XMin, XMax), YMin);
            default:
                return new Vector2(XMin, Random.Range(YMin, YMax));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        enemySpawnCountdown = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        enemySpawnCountdown -= Time.deltaTime;
        if (enemySpawnCountdown <= 0) {
            GameObject newObject = Random.Range(0, 2) == 0 ? Instantiate(Enemy) : Instantiate(Friend);
            enemySpawnCountdown = spawnTime;
            newObject.transform.SetPositionAndRotation(
                generateRandomSpawnPosition(),
                new Quaternion());
        }
    }
}
