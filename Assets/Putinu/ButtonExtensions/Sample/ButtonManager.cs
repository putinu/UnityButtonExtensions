using System.Collections;
using System.Collections.Generic;
using Putinu.ButtonExtensions;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : ButtonHandler
{
    [SerializeField] private Image button;
    [Space(20)]
    [SerializeField] private Text pointerDownText;
    [SerializeField] private Text pointerUpText;
    [SerializeField] private Text pointerEnterText;
    [SerializeField] private Text pointerExitText;
    [SerializeField] private Text pointerClickText;
    [SerializeField] private Text pointerDoubleClickText;
    [SerializeField] private Text pointerHoldDownText;
    
    public override void OnPointerDown()
    {
        button.color = Color.red;
        StartCoroutine(ActivateText(pointerDownText, 0.2f));
    }

    public override void OnPointerUp()
    {
        button.color = Color.white;
        StartCoroutine(ActivateText(pointerUpText, 0.2f));
    }

    public override void OnPointerEnter()
    {
        StartCoroutine(ActivateText(pointerEnterText, 0.2f));
    }

    public override void OnPointerExit()
    {
        StartCoroutine(ActivateText(pointerExitText, 0.2f));
    }

    public override void OnPointerClick()
    {
        StartCoroutine(ActivateText(pointerClickText, 0.2f));
    }

    public override void OnPointerDoubleClick()
    {
        StartCoroutine(ActivateText(pointerDoubleClickText, 0.2f));
    }

    public override void OnPointerHoldDown()
    {
        StartCoroutine(ActivateText(pointerHoldDownText, 0.2f));
    }

    private static IEnumerator ActivateText(Text text, float time)
    {
        text.color = Color.white;
        yield return new WaitForSeconds(time);
        text.color = Color.gray;
    }
}
