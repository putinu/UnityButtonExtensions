using UnityEngine;

[CreateAssetMenu(menuName = "UnityButtonExtension/Create new button setting")]
public class ButtonSetting : ScriptableObject
{
    /// <summary>
    /// ダブルクリックの間隔の上限時間
    /// </summary>
    public float maxDoubleClickInterval = 0.2f;
    
    /// <summary>
    /// 長押しに所要する時間
    /// </summary>
    public float holdDownTime = 0.5f;
}
