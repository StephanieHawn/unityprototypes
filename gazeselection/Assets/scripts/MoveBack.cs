using UnityEngine;
using System.Collections;

public class MoveBack : MonoBehaviour {

	public void MoveBoxBack()
	{
		transform.position += new Vector3 (0f, 0f, 1f);
	}
}
