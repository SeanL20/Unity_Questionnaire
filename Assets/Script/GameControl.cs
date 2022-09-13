using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public static GameControl Control;
	public int pcurlive;
	public int pmaxlive = 3;
	public int ecurlive;
	public int emaxlive = 5;
	
	// Use this for initialization
	void Awake () {
		pcurlive = pmaxlive;
		ecurlive = emaxlive;
		if (Control != null) {
			Destroy (gameObject);

		} else  {
			DontDestroyOnLoad (Control);
			Control = this;
		}
	}
	
	// Update is called once per frame
	
	void Update(){
		
		if (pcurlive > pmaxlive || ecurlive > emaxlive) {
			pcurlive = pmaxlive;
			ecurlive = emaxlive;
		}

		if (pcurlive <= 0 || ecurlive <= 0) {
			lose ();
		}

	}

	void lose(){
		Application.LoadLevel (Application.loadedLevel);
	}

}
