using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargarPuntuacion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Points").GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetString("Points");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
