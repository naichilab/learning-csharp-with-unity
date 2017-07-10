using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Literal : MonoBehaviour
{
	void Start ()
	{
		//文字列リテラル
		string txt = "文字列";

		//整数リテラル
		int intValue = 123;
		long longValue = 145657634223454642;

		//小数リテラル
		float floatValue = 1.23f;
		double doubleValue = 1.2356;
		decimal decimalValue = 2.34654M;

		Debug.Log (txt);
		Debug.Log (intValue);
		Debug.Log (longValue);
		Debug.Log (floatValue);
		Debug.Log (doubleValue);
		Debug.Log (decimalValue);
	}
}
