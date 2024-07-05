using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text.RegularExpressions;

public class PrintRecordsScript : MonoBehaviour
{
    private int[] records;
    private string[] _records;
    private string result;
    [SerializeField] Text scoreRecords;
    [SerializeField] Text placeRecords;

    void Start()
    {
        //PlayerPrefs.SetString("Record", "");
        string StringRecords = PlayerPrefs.GetString("Record");
        _records = StringRecords.Split(' ');

        int j = 0;
        if (StringRecords.Length > 0)
            records = new int[_records.Length];
        else
            return;
        foreach (var record in _records)
        {
            int temp = 0;
            int.TryParse(record, out temp);
            records[j] = temp;
            Debug.Log(records[j]);
            j++;
        }

        Array.Sort(records);
        int place = 1;
        string places = "";
        for(int i = records.Length-1; i >= 0;i--)
        {
            if (i != records.Length - 1)
            {
                result += "\n";
                places += "\n";
            }
            places += place.ToString();
            result += records[i].ToString();
            place++;
        }
        scoreRecords.text = result;
        placeRecords.text = places;
    }

}
