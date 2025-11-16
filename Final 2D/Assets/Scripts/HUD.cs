using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HUD : MonoBehaviour
{
    [SerializeField] private Transform _checklistParent;
    [SerializeField] private ChecklistItemUI _checklistItemPrefab;
    // Add member variables for all of the Text you'll need to update.

    private List<ChecklistItemUI> _checklistItems;

    // ------------------------------------------------------------------------
    public void SetRequiredItems (List<GameObject> items)
    {
        // For every entry in 'items',
        //      create a new ChecklistItemUI GameObject.
        // Set its parent to _checklistParent.
        // Use the correct method in ChecklistItemUI to setup its required item.
        
    }

    // ------------------------------------------------------------------------
    public void KickedItem(GameObject item)
    {
        // Find the ChecklistItem in _checklistItems whose required item is the
        //      'item' input for this method.
        // Tell that item we found it!
    }

    // ------------------------------------------------------------------------
    public void UpdatePointsText (int commonPoints, int uncommonPoints, int rarePoints)
    {
        // Update all of the text.
    }

    // ------------------------------------------------------------------------
    public void UpdateTimerText (float timeLeft)
    {
        // Update the timer text.
    }
}