using UnityEngine;
using UnityEditor;

public class FollowingScript : MonoBehaviour
{
    [Header("Rotation Point")]
    [SerializeField] private Transform turretRotationpoint;

    [Header("Range")]
    [SerializeField] private float targetingRange = 1f;

    /* Dus, hier onder zie dat wanneeer je de tower geslecteerd hebt dan zie je de Targetting range!
    super episch ig, whatever
    
    -j.j. 26/09/2025

    */
    private void OnDrawGizmosSelected()
    {
        Handles.color = Color.yellow;
        Handles.DrawWireDisc(transform.position, transform.forward, targetingRange);
    }
    private Transform target;

    private void Update()
    { /* dus, als er geen target is, zoek een target*/
        if (target == null)
        {
            FindTarget();
        }
    }
    /*vind target script*/
    private void FindTarget()
    {
    
    }
}

