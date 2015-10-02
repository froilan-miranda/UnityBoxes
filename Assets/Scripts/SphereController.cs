using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

 private float amplitudeX = 10.0f;
 private float amplitudeY = 5.0f;
 private float omegaX = 1.0f;
 private float omegaY = 5.0f;
 private float index;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
 void Update () {
     index += Time.deltaTime;
     float x = amplitudeX*Mathf.Cos (omegaX*index);
     float y = Mathf.Abs (amplitudeY*Mathf.Sin (omegaY*index));
     transform.localPosition= new Vector3(x,y,0);
 }
}
