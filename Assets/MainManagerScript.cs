using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainManagerScript : MonoBehaviour
{

    public Text LevelText;
    public Text TheoryText;
    public Text QuestionText;
    public Text Answers; // for variables;
    public Text ThemeName;

    private string bufferstring;
    private int bufferint;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        bufferint = GetResources.GetResource.getLevel(); // Getting Level from DataBase
        bufferstring = GetResources.GetResource.getTexts(); // Getting Text from DataBase
        
        Debug.Log(bufferint + " " + bufferstring);
        LevelText.text = ("Level " + bufferint);
        TheoryText.text = ("Theory" + bufferstring);
        bufferstring = GetResources.GetResource.getThemeText(); // Getting Theme Text from DataBase
        ThemeName.text = ("Theme" + bufferstring);
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1);
        //
    }

    public void onScrollUp() 
    {
        Debug.Log(TheoryText.rectTransform.rect.top);
        if (TheoryText.rectTransform.rect.yMin >= 10) 
        {
            Debug.Log("Entered IF"+TheoryText.transform.position);
        }
    }

    public void onScrollDown()
    {

    }
    
    public void onNextClickTheory()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void onNextClickTest()
    {

    }
}
