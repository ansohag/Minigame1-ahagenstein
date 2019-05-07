//NameSpaces (Library)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

//Zeile 6 ist eine Klassendeklaration
public class ChangeTest : MonoBehaviour {

    public Text myText;
    public TextMeshProUGUI myTMPText;

    private int countPresses = 0;


    private System.Random rnd = new System.Random();
    // Use this for initialization
    void Start () {
        myText.text = "hallooo";
        myTMPText.text = "nochmal hallooo";
        myText.fontSize = 30;
        Debug.Log(rnd.Next(0, 5));
    }
   

    public void addPress() 
    {
        //machen alle 3 das selbe
        //countPresses++;
        //countPresses += 1;
        countPresses = countPresses + 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
     }

    // Update is called once per frame
    void Update () {
		
	}
}
