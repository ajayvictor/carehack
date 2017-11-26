 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using UnityEngine.UI;

public class arduino : MonoBehaviour {
SerialPort sp = new SerialPort("/dev/cu.usbmodem1421",115200);
    
	// Use this for initialization
	void Start () {
		sp.Open();
        sp.ReadTimeout = 50;
        
	}
	
	// Update is called once per frame
	void Update () {
		try{
            Debug.Log(sp.ReadLine());
			UDPSend.strMessage = sp.ReadLine().ToString();
			gameObject.GetComponent<Text>().text = sp.ReadLine();
        }
        catch (System.Exception){
            
        }
	}
}
