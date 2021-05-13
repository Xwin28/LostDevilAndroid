using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
	public string name;

	[TextArea(3, 10)]
	public string[] sentences;

	public string[] Choose_one;//lựa chọn 1
	public int[] c1;// vị trí trong mảng dialog
	public string[] Choose_two;//lựa chọn 2
	public int[] c2; // vị trí trong mảng dialog;

}
