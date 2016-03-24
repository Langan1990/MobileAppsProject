using UnityEngine;
using System.Collections;

public class CamScript : MonoBehaviour {

	public Transform Chara;
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Chara.position.x + 6, 0, -10);
	}
}
