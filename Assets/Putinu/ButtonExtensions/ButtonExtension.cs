using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Putinu.ButtonExtensions
{
    public class ButtonExtension : MonoBehaviour,
        IPointerDownHandler, IPointerUpHandler, IPointerEnterHandler,
        IPointerExitHandler
    {
        [SerializeField] private ButtonHandler buttonHandler;
        [SerializeField] private ButtonSetting buttonSetting;

        private bool _canDoubleClick = false;
        private bool _isClick = false;
        private bool _isPointerDown = false;
        private bool _isPointerOn = false;

        public void OnPointerDown(PointerEventData eventData)
        {
            _isPointerDown = true;
            _isClick = true;

            buttonHandler.OnPointerDown();
            StartCoroutine(WaitHoldDownOrUp());
            if (_canDoubleClick) return;
            StartCoroutine(WaitDoubleClick());
        
            _isClick = false;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isPointerDown = false;
            buttonHandler.OnPointerUp();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _isPointerOn = true;
            buttonHandler.OnPointerEnter();
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _isPointerOn = false;
            buttonHandler.OnPointerExit();
        }

        /// <summary>
        /// 指定時間内に２度目のクリック入力を待つ
        /// </summary>
        private IEnumerator WaitDoubleClick()
        {
            _canDoubleClick = true;
            var elapsedTime = 0.0f;
            while (elapsedTime <= buttonSetting.maxDoubleClickInterval)
            {
                yield return null;
                if (_isClick)
                {
                    buttonHandler.OnPointerDoubleClick();
                    break;
                }
                elapsedTime += Time.deltaTime;
            }

            _canDoubleClick = false;
        }

        /// <summary>
        /// 長押しするか、ボタンが離されるまでまで待機する
        /// </summary>
        /// <returns></returns>
        private IEnumerator WaitHoldDownOrUp()
        {
            var elapsedTime = 0.0f;
            while (_isPointerDown)
            {
                yield return null;
                if (elapsedTime >= buttonSetting.holdDownTime)
                {
                    buttonHandler.OnPointerHoldDown();
                    yield break;
                }
                else if (!_isPointerOn)
                {
                    yield break;
                }

                elapsedTime += Time.deltaTime;
            }
            // 以下離してしまった時の処理
            buttonHandler.OnPointerClick();
        }
    }
}
