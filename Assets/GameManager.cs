using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Level Won!");
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over.");
            Invoke("Restart", 2f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
