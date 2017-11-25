using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class arduino : MonoBehaviour {
SerialPort sp = new SerialPort("/dev/cu.usbmodem1411",115200);
    
	// Use this for initialization
	void Start () {
		sp.Open();
        sp.ReadTimeout = 50;
        
	}
	
	// Update is called once per frame
	void Update () {
		try{
            Debug.Log(sp.ReadLine());
        }
        catch (System.Exception){
            
        }
	}
}
