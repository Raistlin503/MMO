using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameSetUp : MonoBehaviour
{
    public static GameSetUp GS;

    public Transform[] spawnpoints;
    void OnEnable()
    {
        if(GameSetUp.GS == null)
        {
            GameSetUp.GS = this;
        }
    }
}
