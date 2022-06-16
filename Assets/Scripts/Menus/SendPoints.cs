using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Http;
using UnityEngine.UI;
using System.Threading.Tasks;
using System;

public class SendPoints : MonoBehaviour
{
    private static readonly HttpClient client = new HttpClient();
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Points").GetComponent<UnityEngine.UI.Text>().text = PlayerPrefs.GetString("Points");
        Button SendPoints = GameObject.Find("buttonSend").GetComponent<Button>();
        SendPoints.onClick.AddListener(onClick);
    }

    async void onClick(){
        string name = GameObject.Find("NameText").GetComponent<UnityEngine.UI.Text>().text;
        string country = GameObject.Find("countryText").GetComponent<UnityEngine.UI.Text>().text;
        string points = GameObject.Find("Points").GetComponent<UnityEngine.UI.Text>().text.Split(' ')[1];
        
        var values = new Dictionary<string, string>
        {
            { "name", name },
            { "country", country },
            { "points", points }
        };
        var client = new HttpClient();
        var content = new FormUrlEncodedContent(values);
        try
        {
            var response = await client.PostAsync("http://localhost:8000/ranking/", content);
            var responseString = await response.Content.ReadAsStringAsync();
            Debug.Log(responseString);
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
