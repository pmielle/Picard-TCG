using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<int> cards;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (FindObjectsByType<Player>(FindObjectsSortMode.None).Length > 1) 
        { 
            Debug.Log("Player already exists: destroying...");
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        // load player data
        cards = new() { 1 };
    }
}
