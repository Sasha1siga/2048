using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct Task
{
    public ItemType ItemType;
    public int Number;
    public int Level;
}
public class Level : MonoBehaviour
{
    public int NumberOfBalls = 50;
    public int MaxCreatedBallLevle = 1;

    public Task[] Tasks;
}