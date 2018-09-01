using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfTranslation : MonoBehaviour {

    public float rotationspeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        this.transform.Translate(0, 0, rotationspeed);
		
	}
}
