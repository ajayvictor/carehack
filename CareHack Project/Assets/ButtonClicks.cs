using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour {
	public string phobia;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public  void startfn() {
		Debug.Log(phobia);
		gameObject.GetComponent<UDPSend>().sendString(phobia);
	}
	public void stopfn()
	{
		gameObject.GetComponent<UDPSend>().sendString("stop");
	}
	public void pause() { 
	//gameObject.GetComponent<UDPSend>().sendString("pause");
		//gameObject.GetComponent<UDPSend>().sendString("stop");

	
	}
	public void Nextlvl() {
	
	gameObject.GetComponent<UDPSend>().sendString("nxt1");
	}
	public void aer() { 
	phobia = "acrophobia";
	}
	public void arc()
	{
		phobia = "arachnophobia";
	}

}
