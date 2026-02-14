using UnityEngine;

public class winscript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("you have won!");
    }
}