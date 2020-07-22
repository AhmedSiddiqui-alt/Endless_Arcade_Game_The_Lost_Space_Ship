using UnityEngine;

public class collionOfSpaceShip : MonoBehaviour {
    public spaceShipMovement movement;
void OnCollisionEnter(Collision collisionInfoOfSpaceShip)
    {
        if (collisionInfoOfSpaceShip.collider.tag == "spaceship")
    {
        movement.enabled = false;
        FindObjectOfType<spaceshipManager>().EndGame();
    }
    }
	
}
