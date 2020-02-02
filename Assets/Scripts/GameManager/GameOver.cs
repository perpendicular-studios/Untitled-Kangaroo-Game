using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    bool gameHasEnded = false;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Loser();
        }
    }

    void Loser ()
    {
        SceneManager.LoadScene("EndScreen");
    }

}
