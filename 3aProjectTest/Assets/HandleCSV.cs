using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class HandleCSV : MonoBehaviour
{
    public GameObject RightUpperArm;
    public GameObject LeftUpperArm;
    public GameObject Ribs;

    void Start()
    {
        ReadCSVFile();
    }

    void ReadCSVFile()
    {
        var oldRRotation = new Vector3(0, 0, 0);
        var oldLRotation = new Vector3(0, 0, 0);
        var oldRibsRotation = new Vector3(0, 0, 0);
        string[] bodyParts = { "RightUpperArm", "LeftUpperArm", "ChestTop" };
        //string path = "E:\\UnityProjects\\3aProjectTest\\Assets\\data.csv";
        StreamReader strReader = new StreamReader("E:\\UnityProjects\\3aProjectTest\\Assets\\data.csv");
        bool endOfFile = false;
        while (!endOfFile)
        {
            string data_String = strReader.ReadLine();
            if (data_String == null)
            {
                endOfFile = true;
                break;
            }
            //string readText = File.ReadAllText(path);
            //data_String = readText.ReadLine();


            var data_values = data_String.Split(',');
            for (int i = 0; i < data_values.Length; i++)
            {
                try
                {
                    if (string.Compare((bodyParts[0]), data_values[0].ToString()) == 0)
                    {
                        var newRotation = new Vector3(float.Parse(data_values[1]), float.Parse(data_values[2]), float.Parse(data_values[3]));
                        Debug.Log(newRotation.x);
                        if ((newRotation.x != oldRRotation.x) || (newRotation.y != oldRRotation.y) || (newRotation.z != oldRRotation.z))
                        {
                            RightUpperArm.transform.Rotate(newRotation.x, newRotation.y, newRotation.z, Space.World);
                            oldRRotation.x = newRotation.x;
                            oldRRotation.y = newRotation.y;
                            oldRRotation.z = newRotation.z;
                            Debug.Log("Test for UpperArm");
                            break;

                        }
                    }
                    else if (string.Compare((bodyParts[1]), data_values[0].ToString()) == 0)
                    {
                        var newRotation = new Vector3(float.Parse(data_values[1]), float.Parse(data_values[2]), float.Parse(data_values[3]));
                        Debug.Log(newRotation.x);
                        if ((newRotation.x != oldLRotation.x) || (newRotation.y != oldLRotation.y) || (newRotation.z != oldLRotation.z))
                        {
                            LeftUpperArm.transform.Rotate(newRotation.x, newRotation.y, newRotation.z, Space.World);
                            oldLRotation.x = newRotation.x;
                            oldLRotation.y = newRotation.y;
                            oldLRotation.z = newRotation.z;
                            Debug.Log("Test for LeftArm");
                            break;

                        }
                    }

                    else if (string.Compare((bodyParts[2]), data_values[0].ToString()) == 0)
                    {
                        var newRotation = new Vector3(float.Parse(data_values[1]), float.Parse(data_values[2]), float.Parse(data_values[3]));
                        Debug.Log(newRotation.x);
                        if ((newRotation.x != oldRibsRotation.x) || (newRotation.y != oldRibsRotation.y) || (newRotation.z != oldRibsRotation.z))
                        {
                            Ribs.transform.Rotate(newRotation.x, newRotation.y, newRotation.z, Space.World);
                            oldRibsRotation.x = newRotation.x;
                            oldRibsRotation.y = newRotation.y;
                            oldRibsRotation.z = newRotation.z;
                            Debug.Log("Test for Ribs");
                            break;

                        }
                    }

                }
                catch
                {

                }
            }




        }
    }
    
}


 