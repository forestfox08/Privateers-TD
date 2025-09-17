using UnityEngine;

public class SecPathManager : MonoBehaviour
{
    [SerializeField] public static SecPathManager secondary;

    public Transform[] Start;
    public Transform[] EnemyPath;

    private void Awake()
    {
        secondary = this;
    }
}
