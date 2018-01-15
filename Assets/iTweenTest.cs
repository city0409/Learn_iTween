using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class iTweenTest : MonoBehaviour 
{
    public Transform[] path;
    [Range (0f,1f)]
    public float percent = 0.0f;

    private void Start () 
	{
        Hashtable myHT = new Hashtable();
        myHT.Add("easetype", iTween.EaseType.easeInOutElastic);
        myHT.Add("time", 2);
        myHT.Add("x", 3);
        iTween.MoveTo(gameObject, myHT);
        //iTween.PointOnPath(path, percent);
	}
	
	private void Update () 
	{
		transform .position =iTween.PointOnPath(path, percent);
        //if (percent<1)
        //    percent += 0.01f;
        //else 
        //    percent = 0f;
    }
}
