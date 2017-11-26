using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClicks : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public  void startfn() { 
		gameObject.GetComponent<UDPSend>().sendString("arachnophobia");
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
	
	gameObject.GetComponent<UDPSend>().sendString("nxt");
	}
}
