using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuiltinTypes : MonoBehaviour
{
	void Start ()
	{
		string txt = "文字列"; 	//文字列の変数
		int num1 = 12; 			//整数の変数
		float num2 = 1.23f;		//小数の変数
		double num3 = 2.4;		//小数の変数

		Debug.Log (txt);
		Debug.Log (num1);
		Debug.Log (num2);
		Debug.Log (num3);

		//文字列型の変数に数値は入れられない。
		//string txt2 = 123;
		//int num4 = "aaa";
	}
}
