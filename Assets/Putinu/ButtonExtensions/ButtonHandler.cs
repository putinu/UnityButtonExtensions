using UnityEngine;

namespace Putinu.ButtonExtensions
{
    public class ButtonHandler : MonoBehaviour
    {
        /// <summary>
        /// ボタンにカーソルが乗った時
        /// </summary>
        public void OnPointerEnter()
        {
            Debug.Log("enter");
        }

        /// <summary>
        /// ボタンからカーソルが離れた時
        /// </summary>
        public void OnPointerExit()
        {
            Debug.Log("exit");
        }

        /// <summary>
        /// ボタンを押した時
        /// </summary>
        public void OnPointerDown()
        {
            Debug.Log("down");
        }

        /// <summary>
        /// ボタンを離した時
        /// </summary>
        public void OnPointerUp()
        {
            Debug.Log("up");
        }

        /// <summary>
        /// ボタンをクリックした時
        /// </summary>
        public void OnPointerClick()
        {
            Debug.Log("click");
        }

        /// <summary>
        /// ボタンをダブルクリックした時
        /// </summary>
        public void OnPointerDoubleClick()
        {
            Debug.Log("Double Click!");
        }

        /// <summary>
        /// ボタンを長押しした時
        /// </summary>
        public void OnPointerHoldDown()
        {
            Debug.Log("hold down");
        }
    }
}
