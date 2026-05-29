using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    private float delay = 0.2f;

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

    void Start()
    {
        DetectScene();
        
    }

    void DetectScene()
    {
        
        switch(SceneManager.GetActiveScene().buildIndex)
        {
            case 0:
                StartCoroutine(loadSceneOnDelay(1, 2));
                break;
            
            default:
                return;
                break;
        }

    }

    private IEnumerator loadSceneOnDelay(int cena)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(cena);
    }

    private IEnumerator loadSceneOnDelay(int cena1, int cena2)
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene(cena1);
        Debug.Log(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(cena2, LoadSceneMode.Additive);
    }
}



