using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // libreria para cargar la interfaz grafica de usuario

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance = null;
    public bool startedGame = false;
    public Text title;
    public Button startBTN;

    private void Awake()
    {
        if (sharedInstance==null)
        {
            sharedInstance = this;
        }
    }
    public void StartGame()
    {
        startedGame = true;
        title.enabled = false;
        startBTN.gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
