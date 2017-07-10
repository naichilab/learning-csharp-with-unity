using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastSample : MonoBehaviour
{
	void Start ()
	{
		// (型名)変数名 で変換できる。

		// double -> int 変換
		double d = 123.257554;
		int n = (int)d;

		Debug.Log (d);
		Debug.Log (n);

		//数値 -> 文字列変換
		string txt1 = d.ToString ();
		string txt2 = n.ToString ();


		//文字列 -> 数値の変換
		double d2 = double.Parse ("1.234");
		int n2 = int.Parse ("12345");

	}
}
