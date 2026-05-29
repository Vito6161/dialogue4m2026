using UnityEngine;
using System;

public class Moeda : MonoBehaviour
{
    public static event Action CollectedCoins;

    public void OnTriggerEnter(Collider other)
    {
        
        if(other.CompareTag("Player")) CollectedCoins?.Invoke();
        Destroy(gameObject);
    }
}


