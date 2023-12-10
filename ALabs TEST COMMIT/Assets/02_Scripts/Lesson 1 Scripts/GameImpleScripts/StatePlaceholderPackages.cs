using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StatePlaceholderPackages : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");

        if (eventData.pointerDrag != null)
        {
            RectTransform draggedRectTransform = eventData.pointerDrag.GetComponent<RectTransform>();
            RectTransform targetRectTransform = GetComponent<RectTransform>();

            // Set the anchored position of the dragged object to the target's anchored position
            draggedRectTransform.anchoredPosition = targetRectTransform.anchoredPosition;

            Debug.Log("Object dropped on: " + eventData.delta);

            // Find the GameObject by name
            GameObject placeholder1 = GameObject.Find(name);

            // Do something with the found GameObject
            if (placeholder1 != null)
            {
                Debug.Log("Found Placeholder1: " + placeholder1.name);
                // You can access components or perform other operations on placeholder1 here
            }
            else
            {
                Debug.LogWarning("Placeholder1 not found");
            }
        }
    }
}
