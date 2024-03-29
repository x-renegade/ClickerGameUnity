using UnityEngine;
using UnityEngine.EventSystems;

public class Monkey : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler {
    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("asdasdasd");
    }

    public void OnPointerDown(PointerEventData eventData) {
        Debug.Log("asdasdasd");
    }

    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("asdasdasd");
    }

    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("asdasdasd");
    }
}
