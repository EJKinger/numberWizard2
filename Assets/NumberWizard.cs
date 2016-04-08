using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
  
  int max;
  int min;
  int guess;
  int maxGuessesAllowed = 10;
	// Use this for initialization
  void Start () {
    startGame ();
  }
  
  public Text text;
	
  public void guessHigher () {
	min = guess;
	guess = (max + min) / 2;
	updateUser ();
  }
  
  public void guessLower () {
	max = guess;
	guess = guess / 2;
	updateUser ();
  }
  
  public void correct () {
	Application.LoadLevel ("Lose");
  }
  
  void updateUser () {
    print ("Is the number higher or lower than " + guess + "?");
    print ("Up arrow for lower, Down arrow for higher and return for equal");
    maxGuessesAllowed--;
    if (maxGuessesAllowed == 0){
      Application.LoadLevel ("Win");
    }
	text.text = guess.ToString ();
  }
  
  void startGame (){
    max = 1000;
    min = 0;
    guess = Random.Range(0, 1000);
    print ("Welcome to Number Wizard!!");
    print ("Pick a number in your head, but don't tell me!");
    print ("The highest number you can pick is " + max);
    print ("The lowest number you can pick is " + min);    
    updateUser ();
    max = max + 1;
  }
}
