using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    public Transform nextPoint;
    public GameObject[] enemies;
    public string enemieName;
    void Start()
    {   
        string name = this.gameObject.name;
        enemieName = "Enemy"+ name;
        enemies = GameObject.FindGameObjectsWithTag(enemieName);
    }
}
