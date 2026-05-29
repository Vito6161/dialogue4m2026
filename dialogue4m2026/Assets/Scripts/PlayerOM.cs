using System;
using UnityEngine;

public class PlayerOM : MonoBehaviour
{
    public static event Action OnCoinsChanged;

    
    public static void TriggerCoinsChange()
    {
        
        OnCoinsChanged?.Invoke();
    }
    
}