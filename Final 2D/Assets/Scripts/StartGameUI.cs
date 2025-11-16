using UnityEngine;

// You don't need to code in this class at all :)
public class StartGameUI : MonoBehaviour
{
    [SerializeField] private GameController _gameController;

    // ------------------------------------------------------------------------
    // You don't need to code in this method :)
    public void StartButton()
    {
        _gameController.StartGame();
    }
}   
