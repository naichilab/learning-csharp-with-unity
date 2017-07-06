# <span>Unityで覚えるC#</span>

2017-07-15

---

# こんにちは

+++?image=gitpitch/img/naichi.jpg&size=contain

+++

## ないち

@naichilab

+++

## 何してる人？

* 職業：プログラマー
* 趣味：Unity/C#
* なんかそれっぽい資格
  * NW/DB/SCとか

---

# 今日話すこと

+++

## <span>C#の"超"基礎</span>

を Unity 上で。

+++

## <span>C#</span>

プログラミング言語

+++

## Unity

ゲームエンジン

+++

## <span>C#</span>とUnityは別物！

それぞれにお作法がある。

覚えること多くて大変ですね。

---

# 対象

+++

## 超初心者

Unity興味ある

&

プログラミング分かんない

みたいな人

---

# まずは全体像から

---

# <span>Unityの領域</span>

+++

## エディタ

+++?image=gitpitch/img/unityeditor.png&size=contain

これ。

+++

## Unityは

* 世界(Scene)
* モノ(GameObject)
* 挙動(Component)

これらを組み合わせてゲームを作る。

+++?image=gitpitch/img/tanks.png&size=contain

このゲームだと。

+++

* 世界(Scene)
  * 重力や時間を設定して
* モノ(GameObject)
  * 建物や戦車などを置いて
* 挙動(Component)
  * "戦車に弾を打つ" などの挙動を与える

---

## <span>C#の領域</span>

* 型/演算子/変数/関数/クラス/インスタンス/関数/......

+++

---

# Hello, World!!

+++

こんにちは！!

---

```
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonoBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

}
```
あ〜〜〜

@[1](ほげ aaa jjiugfy gugiuh)
@[3](dydfiguygiughoi)
@[5-7](aaaaaaaaa)

---?code=path/to/source.file



---

EOF
