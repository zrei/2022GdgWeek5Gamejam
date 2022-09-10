using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Friend;
    public List<GameObject> Enemy;
    [SerializeField] private float spawnTime;
    private float enemySpawnCountdown;

    public float XMin;
    public float XMax;
    public float YMin;
    public float YMax;

    void spawnEntity(bool spawnEnemy) {
        Vector2 pos;
        Vector2 velocity;
        switch (Random.Range(0, 4)) {
            case 0:
                pos = new Vector2(Random.Range(XMin, XMax), YMax);
                velocity = new Vector2(Random.Range(XMin, XMax), YMin) - pos;
                break;
            case 1:
                pos = new Vector2(XMax, Random.Range(YMin, YMax));
                velocity = new Vector2(XMin, Random.Range(YMin, YMax)) - pos;
                break;
            case 2:
                pos = new Vector2(Random.Range(XMin, XMax), YMin);
                velocity = new Vector2(Random.Range(XMin, XMax), YMax) - pos;
                break;
            default:
                pos = new Vector2(XMin, Random.Range(YMin, YMax));
                velocity = new Vector2(XMax, Random.Range(YMin, YMax)) - pos;
                break;
        }
        if (spawnEnemy) {
            GameObject enemy = Instantiate(Enemy[Random.Range(0, Enemy.Count)]);
            enemy.transform.SetPositionAndRotation(pos, new Quaternion());
            enemy.GetComponent<Enemy>().setVelocity(velocity);
        } else {
            GameObject friend = Instantiate(Friend);
            friend.transform.SetPositionAndRotation(pos, new Quaternion());
            friend.GetComponent<Friend>().setVelocity(velocity);
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
            spawnEntity(Random.Range(0, 5) != 0);
            enemySpawnCountdown = spawnTime;
        }
    }
}
