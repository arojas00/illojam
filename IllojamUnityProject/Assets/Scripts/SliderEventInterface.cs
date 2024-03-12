using UnityEngine;
using UnityEngine.EventSystems;

public class SliderEventInterface : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    GameObject hand;

    [SerializeField]
    GameObject handShadow;
    //Detect if the Cursor starts to pass over the GameObject
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Cursor.visible = true;
        hand.SetActive(false);
        handShadow.SetActive(false);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Cursor.visible = false;
        hand.SetActive(true);
        handShadow.SetActive(true);
    }
}
