using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform turretRotationpoint;

    [Header("Attribute")]
    [SerializeField] private float targetingRange = 10f;
}

