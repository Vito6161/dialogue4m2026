using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    public static UIManager manager;

    void OnAwake()
    {
        if(manager == null)
        {
            manager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    [SerializeField] private TMP_Text txt;
    public int moedas;

    void OnEnable()
    {
        PlayerOM.OnCoinsChanged += UpdateCoins;
    }

    void OnDisable()
    {
        PlayerOM.OnCoinsChanged -= UpdateCoins;
    }

    void UpdateCoins()
    {
        moedas++;
        txt.text = "Moedas: " + moedas.ToString();
    }
}
