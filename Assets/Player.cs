using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[Serializable]
class SaveData
{
    public List<int> cards;

    public SaveData(List<int> cards)
    {
        this.cards = cards;
    }
}

public class Player : MonoBehaviour
{
    public List<int> cards = new() {};
    string saveFile; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (FindObjectsByType<Player>(FindObjectsSortMode.None).Length > 1) 
        { 
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        // load player data
        saveFile = Path.Combine(Application.persistentDataPath, "save.json");
        if (File.Exists(saveFile))
        {
            Load();
        }
    }

    public void Save()
    {
        SaveData saveData = new(cards);
        string jsonData = JsonUtility.ToJson(saveData);
        File.WriteAllText(saveFile, jsonData);
    }

    void Load()
    {
        string jsonData = File.ReadAllText(saveFile);
        var saveData = JsonUtility.FromJson<SaveData>(jsonData);
        cards = saveData.cards;
    }
}
