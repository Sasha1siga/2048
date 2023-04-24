using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public int Coins;
    public int Level;
    public Color BackgroundColor;
    public bool IsMisicOn;

    public static Progress Instance;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
            Destroy(gameObject);
        Load();
    }

    public void SetLevel(int level)
    {
        Level = level;
        Save();
    }
    public void AddCoins(int value)
    {
        Coins += value;
        Save();
    }
    [ContextMenu(nameof(Save))]
    public void Save()
    {
        SaveSystem.Save(this);
    }
    [ContextMenu(nameof(Load))]
    public void Load()
    {
        ProgressData progressData = SaveSystem.Load();
        if (progressData != null)
        {
            Coins = progressData.Coins;
            Level = progressData.Level;
            BackgroundColor.r = progressData.BackgroundColor[0];
            BackgroundColor.g = progressData.BackgroundColor[1];
            BackgroundColor.b = progressData.BackgroundColor[2];
            BackgroundColor.a = progressData.BackgroundColor[3];
            IsMisicOn = progressData.IsMisicOn;
        }
        else
        {
            Coins = 0;
            Level = 1;
            BackgroundColor = Color.blue * 0.5f;
            IsMisicOn = true;
        }
    }
    [ContextMenu(nameof(DeliteFile))]
    public void DeliteFile()
    {
        SaveSystem.DeleteFile();
    }
}
