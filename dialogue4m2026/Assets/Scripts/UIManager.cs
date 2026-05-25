using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text txt;
    public int moedas;

    void OnEnable()
    {
        Moeda.OnCoinsChanged += UpdateCoins;
    }

    void UpdateCoins()
    {
        moedas++;
        txt.text = "Moedas: " + moedas.ToString();
    }
}
