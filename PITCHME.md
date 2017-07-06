# <span>Unityで覚えるC#</span>

2017-07-15

---

# こんにちは

---

## ないち

@naichilab

---?image=gitpitch/img/naichi.jpg&size=contain

---

## 何してる人？

* 職業：プログラマー
* 趣味：Unity/C#
* なんかそれっぽい資格
  * NW/DB/SCとか

---

# 今日話すこと

---

## <span>C#の"超"基礎</span>

を Unity 上で。

---

## <span>C#</span>って？

プログラミング言語

---

## Unityって？

ゲームエンジン

---

## <span>C#</span>とUnityは別物！

それぞれにお作法がある。

覚えること多くて大変ですね。。。

---

# 対象

---

## 超初心者

Unity興味ある

&

プログラミング分かんない

みたいな人

---

# まずは全体像から

---

# <span>Unityのこと</span>

---?image=gitpitch/img/unityeditor.png&size=contain

## Unityエディタ

これ。

---

## Unityでは

* 世界(Scene)
* モノ(GameObject)
* 挙動(Component)

これらを組み合わせてゲームを作る。

---

* 世界(Scene)を作り
* モノ(GameObject)を置いて
* モノに挙動(Component)を与える

---

![tanks](gitpitch/img/tanks.png)

* 光やカメラを置いて
* 地面や建物、戦車を置いて
* "弾を打つ"などの挙動を与える

---

#＃ 挙動(Component)

* 画像を表示する
* 文字を表示する
* 物理演算をする
* キー入力を受けて動かす

とか。
プログラミングしなくても結構用意されてる。

---

## でも

細かいところは自分で作らなきゃいけない。

-> プログラミング<span>(C#)</span>の出番

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
