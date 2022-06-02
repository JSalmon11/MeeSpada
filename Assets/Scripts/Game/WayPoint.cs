using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Transform nextPoint;
    public GameObject[] enemies;
    public string enemyName;
    void Start()
    {
        try
        {
            string name = this.gameObject.name;
            enemyName = "Enemy"+ name;
            enemies = GameObject.FindGameObjectsWithTag(enemyName);
        }
        catch (System.Exception) {  }
    }
}