using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class system : MonoBehaviour {
	private bool check;
	int count = 9 ;
	public Text poom1,poom2,poom3,poom4,poom5,poom6,poom7,poom8,poom9;	
	public Button gupoom1,gupoom2,gupoom3,gupoom4,gupoom5,gupoom6,gupoom7,gupoom8,gupoom9;
	void Start () {
		check = true;
	}
	void Update () 
	{
		if (
			poom1.text == "X" && poom2.text == "X" && poom3.text == "X" || poom1.text == "X" && poom8.text == "X" && poom7.text == "X" || 
			poom1.text == "X" && poom9.text == "X" && poom5.text == "X" || poom3.text == "X" && poom9.text == "X" && poom7.text == "X" ||
			poom2.text == "X" && poom9.text == "X" && poom6.text == "X" || poom7.text == "X" && poom6.text == "X" && poom5.text == "X" || 
			poom3.text == "X" && poom4.text == "X" && poom5.text == "X" || poom8.text == "X" && poom9.text == "X" && poom4.text == "X" ||
			poom7.text == "X" && poom6.text == "X" && poom5.text == "X")
		{
			print("x win");
		}
		if(
			poom1.text == "O" && poom2.text == "O" && poom3.text == "O" || poom1.text == "O" && poom8.text == "O" && poom7.text == "O" || 
			poom1.text == "O" && poom9.text == "O" && poom5.text == "O" || poom3.text == "O" && poom9.text == "O" && poom7.text == "O" ||
			poom2.text == "O" && poom9.text == "O" && poom6.text == "O" || poom7.text == "O" && poom6.text == "O" && poom5.text == "O" || 
			poom3.text == "O" && poom4.text == "O" && poom5.text == "O" || poom8.text == "O" && poom9.text == "O" && poom4.text == "O" ||
			poom7.text == "O" && poom6.text == "O" && poom5.text == "O")
		{
			print("O win");
		}
		if (count == 0)
		{
			print("summergun");
		}
	}
	void xWin(){
		}
	void oWin(){
		}
	void summergun(){
	}

	public void p1(){
		if (check == true) {
			poom1.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom1.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom1.enabled = false;
	}
	public void p2(){
		if (check == true) {
			poom2.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom2.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom2.enabled = false;
	}
	public void p3(){
		if (check == true) {
			poom3.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom3.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom3.enabled = false;
	}
	public void p4(){
		if (check == true) {
			poom4.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom4.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom4.enabled = false;
	}
	public void p5(){
		if (check == true) {
			poom5.text = "O";
			check = false;
			count = count - 1;

		} else {
			poom5.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom5.enabled = false;
	}
	public void p6(){
		if (check == true) {
			poom6.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom6.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom6.enabled = false;
	}
	public void p7(){
		if (check == true) {
			poom7.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom7.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom7.enabled = false;
	}
	public void p8(){
		if (check == true) {
			poom8.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom8.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom8.enabled = false;
	}
	public void p9(){
		if (check == true) {
			poom9.text = "O";
			check = false;
			count = count - 1;
		} else {
			poom9.text = "X";
			check = true;
			count = count - 1;
		}
		gupoom9.enabled = false;
	}
}
