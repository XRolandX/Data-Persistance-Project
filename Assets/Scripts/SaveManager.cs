using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance;

    // transfer data between scenes
    public string inputName = ""; // from MenuUIHandler
    public int bestCurrentScore = 0;// from MainManager
    public string bestPlayerName; // from MainManager
    //

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }



}
