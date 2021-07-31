using UnityEngine;
using UnityEngine.UI;

public class displayUI : MonoBehaviour
{

    public string myString;
    public Text myText;
    public bool displayInfo;
    public float fadeTime;

    void Start()
    {
        myText = GameObject.Find(this.name + "/Canvas/Text").GetComponent<Text>();
        myText.color = Color.clear;
    }

    // Update is called once per frame
    void Update() {
        
        FadeText();

    }

    void OnMouseOver()
    {
        displayInfo = true;
        
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if (displayInfo)
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
            //myText.color = Color.white;
        }
        else
        {
            myText.text = myString;
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
           // myText.color = Color.clear;
        }
    }

}