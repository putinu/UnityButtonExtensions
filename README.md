# UnityButtonExtensions
## What is UnityButtonExtensions?

UnityButtonExtensionsは、ゲームエンジン「Unity」向けに開発された、ボタンの拡張機能を提供します。
現在提供している機能は、

- ```OnPointerDown()``` ... ボタンを押した時に呼び出される
- ```OnPointerUp()``` ... ボタンを離した時に呼び出される
- ```OnPointerEnter()``` ... ボタンの範囲内にカーソルが入った時に呼び出される
- ```OnPointerExit()``` ... ボタンの範囲外にカーソルが出た時に呼び出される
- ```OnPointerClick()``` ... ボタンをクリックし、離した時に呼び出される
- ```OnPointerDoubleClick()``` ... ダブルクリックした時に呼び出される
- ```OnPointerHoldDown()``` ... 一定時間ボタンを長押しした時に呼び出される

また、ダブルクリックの間隔と長押しの時間については、独自にカスタマイズ出来るようになっています。

## How to use?
## 1. unitypackageをダウンロードし、Importする
https://github.com/putinu/UnityButtonExtensions/releases から```UnityButtonExtensions.unitypackage```をダウンロードし、Unityプロジェクトにインポートします。
<br>

## 2. ボタンの入力に関する設定を行う
```Assets/Putinu/UnityButtonExtensions/ButtonSettings.asset```にて、ダブルクリックの間隔（Max Double Click Interval）や、長押しの時間（Hold Down Time）の設定を行います。
デフォルトで値が設定されているため、そのままでよい場合は2.の操作は無視しても問題ありません。

また、このオブジェクトは```Create/UnityButtonExtensions/Create new button setting```から新しく作成することが出来ます。
<br>

## 3. ボタンの機能を追加するUI(Image)にButtonExtensionコンポーネントをアタッチする
Button Handlerには、4.にて後述するButtonHandlerを継承したクラスをアタッチしたGameObjectをアタッチしてください。

Button Settingには、2.にて設定したオブジェクトをアタッチしてください。

![ButtonExtension](https://user-images.githubusercontent.com/71309829/160279824-76d67222-b687-46a0-87ac-8fcb4ab64869.png)
<br>

## 4. ButtonHandlerを継承したクラスを作成し、管理させるGameObjectにアタッチする
ボタンを管理させるクラスには、```ButtonHandler```を継承し、各メソッドをoverrideすることでボタン入力を取得することができるようになります。

（例）ダブルクリック入力のみを受け取る場合

```
using Putinu.ButtonExtensions;
using UnityEngine;

public class ButtonManager : ButtonHandler
{
    public override void OnPointerDoubleClick()
    {
        Debug.Log("Double Click!");
    }
}
```
<br>

その他の例については、Unitypackageに付属する```Sample/ButtonManager.cs```をご覧ください。
