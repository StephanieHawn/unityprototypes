using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {

	public void MoveItemUp()
	{
		transform.position += new Vector3 (0f, 1f, 0f);
	}
}
