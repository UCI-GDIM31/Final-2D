using TMPro;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameController _gameController;
    // Add member variables to store references to the Text Components for the
    //      various points texts.

    private string _itemString = "Final score: ";

    // ------------------------------------------------------------------------
    public void Activate(int commonPoints, int uncommonPoints, int rarePoints, int finalPoints)
    {
        gameObject.SetActive(true);

        // Update the points text with the final scores.
    }

    // ------------------------------------------------------------------------
    // You don't need to code in this method :)
    public void RestartButton()
    {
        _gameController.RestartGame();
    }
}   
