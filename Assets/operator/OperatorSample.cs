using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorSample : MonoBehaviour
{
	void Start ()
	{
		int a = 10;
		int b = 3;

		int n1 = a + b;	//足し算 = 13 
		int n2 = a - b;	//引き算 = 7  
		int n3 = a * b;	//掛け算 = 30 
		int n4 = a / b;	//割り算 = 3
		int n5 = a % b;	//割り算の余り = 1

		Debug.Log (n1);
		Debug.Log (n2);
		Debug.Log (n3);
		Debug.Log (n4);
		Debug.Log (n5);
	}
}
