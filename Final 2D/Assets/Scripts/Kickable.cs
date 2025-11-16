using UnityEngine;

// Add an enum to represent an item's rarity.

public class Kickable : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private GameObject _explosionVfxPrefab;
    // Add a member variable to represent this item's rarity.

    private bool _wasKicked;
    private GameController _gameController;

    // ------------------------------------------------------------------------
    // You don't need to code in this method :)
    private void Start ()
    {
        _gameController = GameObject.FindFirstObjectByType<GameController>();
    }

    // ------------------------------------------------------------------------
    public void Kick(Vector3 force)
    {
        // Set the 'was kicked' flag.

        // Add the input force to the rigidbody to make the item fly.

        // Let the GameController know this object was kicked.
    }

    // ------------------------------------------------------------------------
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // If this object was kicked, explode.
    }

    // ------------------------------------------------------------------------
    private void Explode()
    {
        // Create the explosion VFX.

        // Destroy this item.
    }
}
