using UnityEngine;
using UnityEngine.UI;
public class scoring : MonoBehaviour
{

    public Transform spaceShip;
    public Text scoreofSpaceShip;
    // Update is called once per frame
    void Update()
    {
        scoreofSpaceShip.text = spaceShip.position.z.ToString("0");
    }
}
