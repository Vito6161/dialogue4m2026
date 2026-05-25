using System;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public static event Action OnCoinsChanged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OnCoinsChanged?.Invoke();
            Destroy(gameObject);
        }
    }
}