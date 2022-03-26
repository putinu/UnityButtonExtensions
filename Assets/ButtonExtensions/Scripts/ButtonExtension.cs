using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonExtension : MonoBehaviour,
    IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler,
    IPointerExitHandler, IPointerClickHandler
{
    [SerializeField] private ButtonHandler buttonHandler;
    [SerializeField] private ButtonSetting buttonSetting;
    [SerializeField] private bool enableDoubleClick = false;

    private bool _canDoubleClick = false;
    private bool _isClick = false;
    private float _holdDownTime = 0.0f;

    public void OnPointerDown(PointerEventData eventData)
    {
        _isClick = true;
        if (enableDoubleClick)
        {
            if (_canDoubleClick) return;
            StartCoroutine(WaitDoubleClick());
        }
        else
        {
            // TODO: 長押し処理の実装を行う
        }
        
        _isClick = false;
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

    private IEnumerator WaitDoubleClick()
    {
        _canDoubleClick = true;
        var time = 0.0f;
        while (time <= buttonSetting.maxDoubleClickInterval)
        {
            yield return null;
            if (_isClick)
            {
                DoubleClick();
                break;
            }
            time += Time.deltaTime;
        }

        _canDoubleClick = false;
    }

    private void DoubleClick()
    {
        buttonHandler.OnPointerDoubleClick();
    }

    private void HoldDown()
    {
        buttonHandler.OnPointerHoldDown();
    }
}
