using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyMovement : MonoBehaviour
{
    [Header("Rigidbody")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Atrributes")]
    [SerializeField] private float moveSpeed = 0f;

    private Transform target;
    private int pathIndex = 0;

    private void Start()
    {
        target = PathManager.main.EnemyPath[pathIndex];
    }

    private void Update()
    {
        if (Vector2.Distance(target.position, transform.position) <= 0.1f) { 
            pathIndex++;


            if (pathIndex >= PathManager.main.EnemyPath.Length) {
                Destroy(gameObject);
                return;
            }
            else
            {
                target = PathManager.main.EnemyPath[pathIndex];
            }
        }
    }
    private void FixedUpdate()
    {
        Vector2 direction = (target.position - transform.position).normalized;

        rb.linearVelocity = direction * moveSpeed;
    }
}
