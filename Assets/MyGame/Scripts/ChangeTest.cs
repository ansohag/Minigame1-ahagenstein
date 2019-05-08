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
    public TestingRandom myScript;

    private int countPresses = 0;


    private System.Random rnd = new System.Random();
    private System.Random seedRnd = new System.Random(123);


    // Use this for initialization
    void Start () {
        myText.text = "hallooo";
        myTMPText.text = "nochmal hallooo";
        myText.fontSize = 30;
        Debug.Log("randommmmm " + rnd.Next(0, 5));
        Debug.Log("randommmmm " + UnityEngine.Random.Range(0, 1));
    }
   

    public void addPress() 
    {
        //machen alle 3 das selbe
        //countPresses++;
        //countPresses += 1;
        countPresses = countPresses + 1;
        Debug.Log("counts: " + countPresses);
        myText.text = countPresses.ToString();
        Debug.Log("randommmmm seed " + seedRnd.Next(0, 5));
        myScript.ChangeRandomCube();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
