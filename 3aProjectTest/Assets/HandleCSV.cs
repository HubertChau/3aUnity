using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HandleCSV : MonoBehaviour
{
    public GameObject RightUpperArm;

    void Start()
    {
        ReadCSVFile();
    }

    void ReadCSVFile()
    {
        string[] bodyParts = { "RightUpperArm", "LeftUpperArm", "Chest" };
        StreamReader strReader = new StreamReader("E:\\UnityProjects\\3aProjectTest\\Assets\\data.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_String = strReader.ReadLine();
            if(data_String == null)
            {
                endOfFile = true;
                break;
            }

            var data_values = data_String.Split(',');
            /*for (int i = 0; i < data_values.Length; i++)
            {
                Debug.Log("Value" + i.ToString() + "" + data_values[i].ToString());
            }*/
            if(string.Compare((bodyParts[0]), data_values[0].ToString()) == 0)
            {
                RightUpperArm.transform.Rotate(float.Parse(data_values[1]), float.Parse(data_values[2]), float.Parse(data_values[3]));
                Debug.Log("working" + float.Parse(data_values[1]));
                break;
            }
            //Debug.Log(data_values[0].ToString() + " " + data_values[1].ToString() + " " + data_values[2].ToString() + " " + data_values[3].ToString());
        }
    }
}
 