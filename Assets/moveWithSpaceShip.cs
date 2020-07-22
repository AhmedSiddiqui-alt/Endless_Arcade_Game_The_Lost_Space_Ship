using UnityEngine;

public class moveWithSpaceShip : MonoBehaviour {
    public Transform spaceShip;
    public Vector3 offSet;

	// Update is called once per frame
	void Update () {
        transform.position = spaceShip.position + offSet;
	}
}
