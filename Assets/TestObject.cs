﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TestObject : MonoBehaviour 
{
    private void Start()
    {
        CSV.CSVManager.Init();


       //var testData = CSV.CSVManager.LoadData("TestData.csv");
       //Debug.Log(testData.TableInfo());
       //
       //ar cList = CSV.CSVUtilities.Column(testData, 3);
       //
       //foreach(var elem in cList)
       //{
       //    Debug.Log(elem);
       //}
       //
       //var rList = CSV.CSVUtilities.Row(testData, 2);
       //
       //foreach(var elem in rList)
       //{
       //    Debug.Log(elem);
       //}
    }
}