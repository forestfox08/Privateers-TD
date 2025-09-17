using UnityEngine;

public class PathManager : MonoBehaviour
{
    // 
    [SerializeField] public static PathManager main;

    public Transform[] Start;
    public Transform[] EnemyPath;

    private void Awake()
    {
        main = this;
    }
}
