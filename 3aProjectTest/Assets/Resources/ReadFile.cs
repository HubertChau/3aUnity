using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadFile : MonoBehaviour
{
    string[] namesArray;
    string myFilePath, fileName;

    void Start()
    {
        fileName = "test.txt";
        myFilePath = Application.dataPath + "/" + fileName;
    }

    public void ReadFromTheFile()
    {
        namesArray = File.ReadAllLines(myFilePath);
        
        foreach(string line in namesArray)
        {
            print(line);
        }
    }
}
