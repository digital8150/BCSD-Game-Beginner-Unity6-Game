using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello Unity");

        int level = 5;
        float strength = 15.5f;
        string playerName = "Player1";
        bool isGameOver = false;

        string[] monsters = { "Goblin", "Orc", "Dragon" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 2;
        monsterLevel[2] = 3;

        for (int i = 0; i < monsters.Length; i++)
        {
            Debug.Log($"Monster: {monsters[i]}, Level: {monsterLevel[i]}");
        }

        List<string> items = new List<string>();
        items.Add("Sword");
        items.Add("Shield");

        int exp = 1500;
        exp = 1500 * 320;
        level = exp / 100;
        strength = level * 3.1f;


        Actor player = new Actor(); 
    }
}
