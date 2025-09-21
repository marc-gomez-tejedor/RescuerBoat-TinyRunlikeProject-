using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPuntuation : MonoBehaviour
{
    private int totalCoins;
    private Transform[] coins;
    public GameObject coinsObj;

    public int GetMaxPuntuation() 
    {
        coins = coinsObj.GetComponentsInChildren<Transform>();
        totalCoins = coins.Length;               
        return totalCoins-1;
    }
}
