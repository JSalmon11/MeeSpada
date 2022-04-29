using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadCountries : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown listCountry = transform.GetComponent<Dropdown>();
        listCountry.captionText.text = "País";

        listCountry.options.Clear();

        var curPath = System.IO.Directory.GetCurrentDirectory();
        var reader = new StreamReader(curPath+"/Assets/Scripts/Menus/paises.csv");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            var values = line.Split(',');

            listCountry.options.Add(new Dropdown.OptionData() { text = values[0] });
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
