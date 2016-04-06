using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
  
  int max;
  int min;
  int guess;
	// Use this for initialization
	void Start () {
    startGame ();
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetKeyDown (KeyCode.UpArrow)) {
      min = guess;
      guess = (max + min) / 2;
      updateUser ();
    }
    else if (Input.GetKeyDown (KeyCode.DownArrow)) {
      max = guess;
      guess = guess / 2;
      updateUser ();
    }
    else if (Input.GetKeyDown (KeyCode.Return)) {
      print ("I Won!!");
      startGame ();
    }
	}
  
  void updateUser () {
    print ("Is the number higher or lower than " + guess + "?");
    print ("Up arrow for lower, Down arrow for higher and return for equal");
  }
  
  void startGame (){
    max = 1000;
    min = 1;
    guess = 500;
    print ("Welcome to Number Wizard!!");
    print ("Pick a number in your head, but don't tell me!");
    print ("The highest number you can pick is " + max);
    print ("The lowest number you can pick is " + min);    
    updateUser ();
    max = max + 1;
  }
}
