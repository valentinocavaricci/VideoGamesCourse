using UnityEngine;

public class DeathHoleTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER HIT by: " + other.name);
    }
}