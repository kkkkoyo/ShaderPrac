using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockCountroller : MonoBehaviour {

	[SerializeField]private int ss = 0;
	[SerializeField]private string number = "2";

	void Start()
	{
		if(ss==7||ss==8)
		{
		StartCoroutine(SS());

		}else
		StartCoroutine(Times());
	}
	IEnumerator SS()
	{
		yield return new WaitForSeconds(0.001f);


		string datetimeStrmm = System.DateTime.Now.Millisecond.ToString();

		if(datetimeStrmm.Length==1)
		{
			datetimeStrmm="0"+datetimeStrmm;
		}
		if(ss==7)
		{
			number = datetimeStrmm.Substring(0,1);
		}

		else if(ss==8)
		{
			number = datetimeStrmm.Substring(1,1);
		}
		List<string> num = new List<string>();
		List<string> nonum = new List<string>();

		if(number=="0")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			nonum.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="1")
		{
			num.Add("00");
			num.Add("01");
			nonum.Add("02");
			nonum.Add("10");
			num.Add("11");
			nonum.Add("12");
			nonum.Add("20");
			num.Add("21");
			nonum.Add("22");
			nonum.Add("30");
			num.Add("31");
			nonum.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="2")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			nonum.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			nonum.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="3")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			nonum.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="4")
		{
			num.Add("00");
			nonum.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}else if(number=="5")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			nonum.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="6")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			nonum.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="7")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			nonum.Add("20");
			nonum.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}else if(number=="8")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="9")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}
		for(int i=0;i<num.Count;i++)
		{
			GameObject _child = transform.Find (num[i]).gameObject;
			iTween.RotateTo(_child.gameObject, iTween.Hash(
				"y", 90,
				"time", 0.001f
			));
		}
		for(int i=0;i<nonum.Count;i++)
		{

			GameObject _child = transform.Find (nonum[i]).gameObject;
			iTween.RotateTo(_child.gameObject, iTween.Hash(
				"y", 0,
				"time", 0.001f
			));
		}
		yield return new WaitForSeconds(0.001f);
		StartCoroutine(SS());
	}
	private IEnumerator Times () {

		yield return new WaitForSeconds(0.6f);
		string datetimeStr = datetimeStr = System.DateTime.Now.Second.ToString();
		if(ss==1||ss==2)
		{
			datetimeStr = System.DateTime.Now.Hour.ToString();

		}

		if(ss==3||ss==4)
		{
			datetimeStr = System.DateTime.Now.Minute.ToString();
		}
		if(datetimeStr.Length==1)
		{
			datetimeStr="0"+datetimeStr;
		}
		if(ss==5||ss==3||ss==1)
		{
			Debug.Log(datetimeStr);
			number = datetimeStr.Substring(0,1);
		}

		else if(ss==6||ss==4||ss==2)
		{
			number = datetimeStr.Substring(1,1);
		}

		List<string> num = new List<string>();
		List<string> nonum = new List<string>();

		if(number=="0")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			nonum.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="1")
		{
			num.Add("00");
			num.Add("01");
			nonum.Add("02");
			nonum.Add("10");
			num.Add("11");
			nonum.Add("12");
			nonum.Add("20");
			num.Add("21");
			nonum.Add("22");
			nonum.Add("30");
			num.Add("31");
			nonum.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="2")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			nonum.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			nonum.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="3")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			nonum.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="4")
		{
			num.Add("00");
			nonum.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}else if(number=="5")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			nonum.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="6")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			nonum.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="7")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			nonum.Add("20");
			nonum.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}else if(number=="8")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			num.Add("30");
			nonum.Add("31");
			num.Add("32");
			num.Add("40");
			num.Add("41");
			num.Add("42");
		}else if(number=="9")
		{
			num.Add("00");
			num.Add("01");
			num.Add("02");
			num.Add("10");
			nonum.Add("11");
			num.Add("12");
			num.Add("20");
			num.Add("21");
			num.Add("22");
			nonum.Add("30");
			nonum.Add("31");
			num.Add("32");
			nonum.Add("40");
			nonum.Add("41");
			num.Add("42");
		}
		for(int i=0;i<num.Count;i++)
		{
			GameObject _child = transform.Find (num[i]).gameObject;
			iTween.RotateTo(_child.gameObject, iTween.Hash(
				"y", 90,
				"time", 0.4f
			));
		}
		for(int i=0;i<nonum.Count;i++)
		{

			GameObject _child = transform.Find (nonum[i]).gameObject;
			iTween.RotateTo(_child.gameObject, iTween.Hash(
				"y", 0,
				"time", 0.4f
			));
		}
		yield return new WaitForSeconds(0.4f);

		StartCoroutine(Times());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
