using System;
using UnityEngine;

public class Moeda : MonoBehaviour
{
    public int coins;
    
    public event Action OnCoinsChanged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OnCoinsChanged?.Invoke();
            Destroy(gameObject);
        }
    }
}
