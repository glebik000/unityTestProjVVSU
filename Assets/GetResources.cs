using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetResources : MonoBehaviour
{

    public static GetResources GetResource;

    // Start is called before the first frame update
    void Start()
    {
        GetResource = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getTexts() 
    {
        string buffer = "Test DB req result";
        //
        buffer = reqText();
        //
        return buffer;
    }

    public string getThemeText()
    {
        string buffer = "Test DB req result";
        //
        buffer = reqThemeText();
        //
        return buffer;
    }

    public int getLevel()
    {
        int buffer = 0;
        //
        buffer = reqLevel();
        //
        return buffer;
    }

    private string reqThemeText()
    {
        string result = "Test Theme result";
        //request here 
        return result;
    }

    private string reqText()
    {
        string result = "Test result";
        //request here 
        return result;
    }

    private int reqLevel()
    {
        int result = 99;
        //request here 
        return result;
    }


}
