using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SaveController: MonoBehaviour
{
    public Color colorPlayer = Color.white;
    public Color colorEnemy = Color.white;
    public string namePlayer;
    public string nameEnemy;

    private static SaveController _instance;
    // Propriedade est�tica para acessar a inst�ncia
    public static SaveController Instance
    {
        get
        {
            if (_instance == null)
            {
                // Procure a inst�ncia na cena
                var objectFound = Object.FindFirstObjectByType<SaveController>();
                if (objectFound != null)
                    // Se n�o encontrar, crie uma nova inst�ncia
                    if (_instance == null)
                {
                    GameObject singletonObject = new GameObject(typeof(SaveController).Name);
                    _instance = singletonObject.AddComponent<SaveController>();
                }
            }
            return _instance;
        }
    }
    private void Awake()
    {
        // Garanta que apenas uma inst�ncia do Singleton exista
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        // Mantenha o Singleton vivo entre as cenas
        DontDestroyOnLoad(this.gameObject);
    }
    public string GetName(bool isPlayer)
    {
        return isPlayer ? namePlayer : nameEnemy;
    }
    public void Reset()
    {
        nameEnemy = "";
        namePlayer = "";
        colorEnemy = Color.white;
        colorPlayer = Color.white;
    }
    public void SaveWinner(string winner)
    {
        PlayerPrefs.SetString("SavedWinner", winner);
    }
    public string GetLastWinner()
    {
        return PlayerPrefs.GetString("SavedWinner");
    }
    public void ClearSave()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
