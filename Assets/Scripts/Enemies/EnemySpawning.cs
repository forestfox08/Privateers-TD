using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    [Header("Enemy Prefabs")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    [SerializeField] private int enemybaseAmount = 5;
    [SerializeField] private float enemiesPerSecond = 0.5f;

    //------------------

    [SerializeField] private float timeSinceSpawn;
    public float CurrentWave = 1f;
    public float timebetweenWaves = 20f;
    private int enemiesLeftOver;
    private int enemiesLeftToSpawn;

    private void Start()
    {
        enemiesLeftToSpawn = enemybaseAmount;
    }
    private int EnemiesPerWave()
    {
        return 
    }
}
