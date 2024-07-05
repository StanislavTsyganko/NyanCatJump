using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsScript : MonoBehaviour
{
    public string StringRecords="";


    public void AddRecord(int record)
    {
        StringRecords = PlayerPrefs.GetString("Record");
        Debug.Log(StringRecords);

        if (StringRecords.Length > 0)
            StringRecords = StringRecords + " ";
        Debug.Log(StringRecords);
        
        StringRecords = string.Concat(StringRecords, record.ToString());
        Debug.Log(StringRecords);

        PlayerPrefs.SetString("Record", StringRecords);
        PlayerPrefs.Save();

        Debug.Log(StringRecords);
    }

}
