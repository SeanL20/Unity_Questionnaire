using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class hearts : MonoBehaviour {

	public Sprite[] PHeartSprites;
	public Sprite[] EHeartSprites;
	public Image HeartUI;
	public Image EHeartUI;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		HeartUI.sprite = PHeartSprites[GameControl.Control.pcurlive];
		EHeartUI.sprite = EHeartSprites [GameControl.Control.ecurlive];
	}
}
