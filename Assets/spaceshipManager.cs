
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class spaceshipManager : MonoBehaviour {
    bool destroyspaceShip=false;
    public Text scoreFinal;
    public Transform spaceShipMovement;


    public void EndGame()
    {
        if(destroyspaceShip==false)
        {
            destroyspaceShip=true;
         
            Invoke("RestartGame",2f);
            
        }
    }
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
	}

