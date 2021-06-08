
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restarDelay = 1f;

    public GameObject completeUI;

    public void Complete()
    {
        Debug.Log("vyhra");
        completeUI.SetActive(true);
    }

    public void EndGame() 
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Znova !!");
            Invoke("Restart",restarDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
  
}
