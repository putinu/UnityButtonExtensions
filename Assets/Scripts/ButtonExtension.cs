using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonExtension : MonoBehaviour,
    IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler,
    IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private ButtonHandler buttonHandler;
    
    
    public void OnPointerDown(PointerEventData eventData)
    {
        buttonHandler.OnPointerDown();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonHandler.OnPointerUp();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonHandler.OnPointerEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonHandler.OnPointerExit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonHandler.OnPointerClick();
    }
}
