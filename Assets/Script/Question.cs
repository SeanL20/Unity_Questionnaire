using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;


public class Question : MonoBehaviour {
	
	int n,a;
	List<int> m = new List<int>();
	private List<string> question = new List<string>(){"Question: \nIf a stranger in the internet talks to you, what do you do? (B)\n" +
		"\nA: Reply and continue talking to the stranger" +
		"\nB: Talk to your parents about the stranger talking to you" +
		"\nC: Ignore the stranger but don’t tell any one" +
		"\nD: Brag about it in school" 
		, "Question: \nIf you see a link to violent video on the internet what do you do? (C)\n" +
		"\nA: Click on it and watch it" +
		"\nB: Share it with your friend" +
		"\nC: Tell your parents about the link" +
		"\nD: Ignore it"
		, "Question: \nIf there is an email addressed to you but is from someone you do not know, what do you do? (D)\n" +
		"\nA: Click on it" +
		"\nB: Delete it and not tell anyone" +
		"\nC: Ask around your group of friend for the sender" +
		"\nD: Tell your parents"
		, "Question: \nWhen you are in a chat room and someone is being rude to you, what do you do? (B)\n" +
		"\nA: Be rude to them back" +
		"\nB: Leave the chatroom" +
		"\nC: Get your friends to help you bully the person" +
		"\nD: Talk them saying that you are sad and cry"
		, "Question: \nWhen you are in a chat room do you: (D)" +
		"\nA: Type in uppercase" +
		"\nB: Be rude to everyone in the chat room" +
		"\nC: All the above" +
		"\nD: None of the above"
		, "Question: \nIn a forum you see a thread where the poster asked for help what do you do? (D)\n" +
		"\nA: Report the poster for being useless" +
		"\nB: Post in the thread saying that the poster is useless" +
		"\nC: All the above" +
		"\nD: Post helpfully tips or lead the poster to a site or person who can help him"};
	private string ch1 = "A";
	private string ch2 = "B";
	private string ch3 = "C";
	private string ch4 = "D";
	private List<string> correct = new List<string>(){"B", "C", "D", "B", "D", "D"};

	void Start(){
		n = UnityEngine.Random.Range(0,5);
		m.Add(n);
		Debug.Log("Random number: " + n);
	}

	void OnGUI(){
		// Constrain all drawing to be within a 800x600 pixel area centered on the screen.
		GUI.BeginGroup (new Rect (Screen.width / 2 - 250, Screen.height / 2 - 200, 500, 400));

		// Draw a box in the new coordinate space defined by the BeginGroup.
		// Notice how (0,0) has now been moved on-screen
		GUI.Box (new Rect (0,0,500,500),"This box is now centered! - here you would put your main menu");
		GUI.Label (new Rect (20,20,460,150), question[n]);
		GUI.Label (new Rect (20,250,50,50), "Answer");
		if (GUI.Button (new Rect (50,300,150,30), ch1)) {
			LiveControl(ch1);
		}
		if (GUI.Button (new Rect (300,300,150,30), ch2)){
			LiveControl(ch2);
		}
		if (GUI.Button (new Rect (50,350,150,30), ch3)){
			LiveControl(ch3);
		}
		if (GUI.Button (new Rect (300,350,150,30), ch4)){
			LiveControl(ch4);
		}

		// We need to match all BeginGroup calls with an EndGroup
		GUI.EndGroup ();

	}

	void UpdateGame(){
		n = UnityEngine.Random.Range(0,4);
		for ( int c = 0; c <= m.Count; c++){
			if (n == m[c]){
				n = UnityEngine.Random.Range(0,4);
			}
		}
		m.Add(n);
	}

	void LiveControl(string ch){
		if(ch != correct[n]){
			GameControl.Control.pcurlive --;
			UpdateGame();
		} else {
			GameControl.Control.ecurlive --;
			UpdateGame();
		}
	}

}
