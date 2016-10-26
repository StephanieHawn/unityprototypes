using UnityEngine;
using System.Collections;

public class BoxGVRGaze : MonoBehaviour, IGvrGazeResponder {

	public void OnGazeEnter(){
		transform.position += new Vector3 (0f, 0f, 1f);

	}

	public void OnGazeExit(){
		Debug.Log ("Gaze Exit");
	}

	public void OnGazeTrigger(){
		Debug.Log ("Gaze Trigger");
	}
}
