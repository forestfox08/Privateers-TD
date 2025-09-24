using UnityEngine;

public class EnemySpawning : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    [SerializeField] private int enemybaseAmount = 5;
    [SerializeField] private float enemiesPerSecond = 0.5f;
    public float timebetweenWaves = 20f;



    void Update()
    {
        
    }
}
