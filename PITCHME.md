# Unityで覚える<span>C#</span>

---

# こんにちは

👇

+++

![naichilab](gitpitch/img/naichi.jpg)

ないち

@naichilab

+++

## 何してる人？

* 職業：プログラマー
* 趣味：Unity/C#
* それっぽい資格
  * NW/DB/SCとか

---

# 今日話すこと

👇

+++

## <span>C#の"超"基礎</span>

を Unity 上で。

+++

## <span>C#</span>って？

プログラミング言語

+++

## Unityって？

ゲームエンジン

+++

## <span>C#</span>とUnityは別物！

それぞれにお作法がある。

覚えること多くて大変ですね。。。

---

# 対象

👇

+++

## 超初心者

Unity興味ある

&

プログラミング分かんない

みたいな人

---

# まずは全体像から

---

# <span>Unityのこと</span>

👇

+++

## Unityでは

* 世界(Scene)
* モノ(GameObject)
* 振る舞い(Component)

これらを組み合わせてゲームを作る。

+++

![tanks](gitpitch/img/tanks.png)

* 光やカメラを置いて
* 地面や建物、戦車を置いて
* "弾を打つ"などの振る舞いを与える

---

# 振る舞い

👇

+++

## 振る舞い

* 画像を表示する
* 文字を表示する
* 物理演算をする
* キー入力を受けて動かす

とか。

+++

プログラミングしなくても

結構な種類用意されてる。

+++

## でも

細かいところは自分で作らなきゃいけない。

* ゲームのルールとか
* 特殊な動き・演出とか

-> プログラミング<span>(C#)</span>の出番

+++

簡単に書けるなら苦労しないよ！

ってことで

ここから<span>C#</span>(プログラミング)の話。

---

# <span>C#</span>

👇

+++

### 機能多い・・・

変数/型/キャスト/コメント/関数/四則演算/配列/条件分岐/繰り返し/例外処理/クラスとインスタンス/構造体/定数/静的クラス/列挙型/プロパティ/デリゲート/ラムダ式/LINQ/非同期処理/Rx/…

---

キリがないので

# <span>C#</span>基礎 変数編

で行きましょう。

---

ここから先、

説明＆デモの繰り返しです。

---

なるべくサンプル用意してます。

興味が湧いたら

あとでダウンロードしてください。

👇

+++

## ダウンロード

[naichilab/learning-csharp-with-unity](https://github.com/naichilab/learning-csharp-with-unity)

+++

## Unityでの開き方

ほげほげ

---

## 今日の目標

* Unityの準備
* <span>C#</span>スクリプトの作成方法
* Hello World!!
* Debug.Log
* コメント
* 変数の宣言と値の代入
* 変数の型
* リテラル
* 四則演算
* 型変換(キャスト)

いけるとこまで！

---

## Unityの準備

👇

+++

![](gitpitch/img/unity-editor-layout.png)

レイアウトを初期化しておく

+++

慣れたら好きなレイアウトでどうぞ。

---

## <span>C#</span>スクリプトの作成方法

sample : create-script

👇

+++

![](gitpitch/img/unity-create-script.png)

Project -> Create -> C# Script

+++

![](gitpitch/img/create-script/create-script-file.png)

できたファイルをダブルクリックで開く

+++

![](gitpitch/img/create-script/create-script-mono.png)

MonoDevelopというエディタが開く

+++?code=Assets/create-script/Sample.cs

簡単に説明

@[1-101](こんな感じのファイルが開きます)
@[1-3](他のファイルを読み込んで使うよーって宣言)
@[1-3](まだ気にしなくていいです)
@[5](Sample : クラス=振る舞い の名前)
@[5](Unity上で作ると必ずMonoBehaviourと書かれる)
@[8-12](Start : 実行時、はじめに1回だけ呼ばれる)
@[14-18](Update : 実行時、毎フレーム呼ばれる)

+++

これで雛形は完成

ここに処理を書き込んでいきます。

+++

(ハマりポイント)

![](gitpitch/img/create-script/create-script-name-mismatch.png)

これはUnityの決まりごと。

---

## Hello World!!

お決まりの練習。

sample : helloworld

👇

+++

![](gitpitch/img/helloworld/helloworld-file.png)

`HelloWorld` スクリプトを作成

(さっきと別ファイル)

+++?code=Assets/helloworld/HelloWorld.cs

Startの中に１行追加する

@[10] (こんな感じ)

+++

## プログラム完成！

`振る舞い` の定義はできた。

+++

## でも

これだけでは動かない。

`振る舞い` は `モノ` に付ける必要がある。

+++

モノ(GameObject)の作成

+++

![](gitpitch/img/helloworld/helloworld-create-empty.png)

Hierarchy -> Create -> Create Empty

+++

![](gitpitch/img/helloworld/helloworld-empty-object.png)

`GameObject` という名前のモノが作られた。

+++

![](gitpitch/img/helloworld/helloworld-rename.png)

分かりにくいのでリネームしましょう。

-> `HelloWorld`

+++

![](gitpitch/img/helloworld/helloworld-components.png)

モノを選択すると、振る舞い一覧が表示される

+++

![](gitpitch/img/helloworld/helloworld-add-component.png)

Hierarchy -> Add Component -> Hello World

+++

![](gitpitch/img/helloworld/helloworld-helloworld-script.png)

(振る舞いが)ついた！

+++

![](gitpitch/img/helloworld/helloworld-play.png)

やっと実行（再生ボタン）

+++

![](gitpitch/img/helloworld/helloworld-playing.png)

ボタンが青くなれば実行できている

+++

![](gitpitch/img/helloworld/helloworld-log.png)

動いた！！（超地味）

+++

![](gitpitch/img/helloworld/helloworld-log-detail.png)

クリックするとちょっと詳しく見れる

+++

まとめ

1. C#スクリプト(振る舞い)を作る
1. モノを作る
1. モノに振る舞いを付ける
1. 動かす！

+++

![](gitpitch/img/helloworld/helloworld-editor.png)

---

## Debug.Log

👇

+++?code=Assets/helloworld/HelloWorld.cs

HelloWorldで使ったやつ

+++

`Debug.Log("XXXXX");`

これを書くと実行時にログが表示される。

+++

プログラムが思い通りに動いているか

確認する基本的な方法。

とりあえず困ったらコレ！

---

## コメント

sample : comment

👇

+++?code=Assets/comment/CommentSample.cs

スラッシュ２つ並べるとコメントが書ける

@[9-10](ここは処理されないコメント行)

+++

コメントは自由に書けます。

複雑になりそうならコメントを残しましょう。

---

## 変数

sample : variables

👇

+++?code=Assets/variables/Variables.cs

いきなりサンプル

@[9](textという箱<変数>を用意)
@[10](箱<変数>に文字列を入れる)
@[11](箱<変数>の内容をLogに書き出す)

+++

## 実行結果

![](gitpitch/img/variables/variables-variables.png)

+++

## 宣言と代入

```
string text;        //変数の宣言
text = "あいうえお";  //値の代入

//宣言と代入を１行で書くこともできる
string text2 = "あいうえお";
```

+++

とりあえず

箱が作れるのね。

ぐらいの認識でOK。

---

## 変数の型（箱の形）

sample : built-in-types

👇

+++

箱<変数>には型がある。

* 文字列用の箱には文字列しか入らない
* 整数用の箱には整数しか入らない
* 小数用の箱には整数か小数しか入らない

+++

## <span>C#</span>に最初から用意されている型

| 型名 | 入れられる値 |
| --- | ---- |
| string | 文字列 |
| int | 整数 |
| long | 整数 |
| float | 小数 |
| double | 小数 |

他にもいっぱい -> [組み込み型一覧](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/built-in-types-table)

+++

```
//文字列の変数
string txt;
txt = "こんにちは";

//整数の変数
int num1;
num1 = 12;

//小数の変数
float num2;
num2 = 1.23f;
```

+++

## 型エラー

型に合わない値は代入できない。

```
//これらはエラーする
string txt;
txt = 123;//文字列型に数値は入らない

int num;
num = "aaa";//数値型に文字列は入らない
```

+++

※ログに表示されるエラーの例

```
error CS0029: Cannot implicitly convert type `int' to `string'
```

intからstringに変換できません!!

エラーよく読めば単純な場合が多い。英語だけど頑張って！

+++

## C#は型がしっかりした言語

型が間違ってると動かない！

逆に言うとエラーで教えてくれる！

---

## リテラル

sample : literal

👇

+++

ダブルクォーテーション "" で囲むと string として扱われる。

```
string text = "あいうえお";
```

+++

ダブルクォーテーション "" で囲まず整数を書くと int として認識される。

```
int num = 10;
```

+++

小数を書くと double として認識される。

```
double num = 1.234;
```

+++

## ハマりやすいところ

float と double と 小数リテラル

```
//1.234 は double として認識されるのでエラーする
float num = 1.234;

//fを付けると float として認識される
//これはOK
float num2 = 1.234f;
```

+++

ややこしいなぁ〜って？

すぐ慣れるのでがんばって。

---

## 四則演算

sample : operator

👇

+++

## 数値の四則演算

```
int a = 10;
int b = 3;

int n1 = a + b;	//足し算 = 13
int n2 = a - b;	//引き算 = 7  
int n3 = a * b;	//掛け算 = 30
int n4 = a / b;	//割り算 = 3
int n5 = a % b;	//割り算の余り = 1
```

珍しいのは % かな？

+++

## ハマりやすいところ

```
int a = 10;
int b = 3;

//3.333... が欲しいのに 3が入る
float f1 = a / b;

//小数に変換してから計算すればOK（変換方法は後ほど）
```

整数同士の計算は整数になる！

+++

## 文字列の演算

文字列は + で結合できる。

```
string txt1 = "こんにちは";
string name = "naichi";
string txt2 = "さん！！";

Debug.Log (txt1 + name + txt2);
//出力 : こんにちはnaichiさん！！
```

---

## 型変換（キャスト）

sample : cast

👇

+++

## 数値同士の変換

`(変換後の型名)変数名` で変換可能

```
// double -> int 変換
double d = 123.257554;
int n = (int)d;

Debug.Log (d);//123.257554
Debug.Log (n);//123
```

当然、小数部の情報は無くなるので注意！

+++

## 数値->文字列

`変数名.ToString()` で変換可能

```
double d = 123.257554;
int n = (int)d;

//数値->文字列変換
string txt1 = d.ToString ();
string txt2 = n.ToString ();
```

+++

## 文字列->数値

`数値型.Parse(文字列)` で変換可能

```
//文字列 -> 数値の変換
double d = double.Parse ("1.234");
int n = int.Parse ("12345");
```

+++

## 応用

文字列に数字を埋め込みたい！

```
int score = 12;

//string text = "あなたのスコアは" + score + "でした。";
// + は文字列同士しか繋げられないのでエラー

string text = "あなたのスコアは" + score.ToString() + "でした。";
//これでOK
```

---

# 質問

どうぞ

---

# 次回 関数編

やる？

---

EOF
