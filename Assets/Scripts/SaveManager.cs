using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

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
        LoadPlayerData();

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    [System.Serializable]
    class SaveData  //class for data to save
    {
        public string inputName;
        public int bestCurrentScore;
        public string bestPlayerName;

    }

    public void SavePlayerData()
    {
        SaveData data = new(); // instance of save data class
        // data to save
        data.inputName = inputName;
        data.bestCurrentScore = bestCurrentScore;
        data.bestPlayerName = bestPlayerName;
        //
        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadPlayerData()
    {
        string pathToSaveFile = Application.persistentDataPath + "/savefile.json";  // created for data path recheck
        if (File.Exists(pathToSaveFile)) // recheck
        {
            string json = File.ReadAllText(pathToSaveFile);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            inputName = data.inputName;
            bestCurrentScore = data.bestCurrentScore;
            bestPlayerName = data.bestPlayerName;

        }


    }
}








