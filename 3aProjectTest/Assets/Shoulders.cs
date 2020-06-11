using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Shoulders : MonoBehaviour
{
    [SerializeField]public GameObject LeftShoulder;
    public TextAsset Angles_LeftShoulder;

    /*[SerializeField] public GameObject Ribs;
    public TextAsset Ribs_Text;

    [SerializeField] public GameObject Neck;
    public TextAsset Neck_Text;

    [SerializeField] public GameObject Hip;
    public TextAsset Hip_Text;

    [SerializeField]public GameObject RightShoulder;
    public TextAsset Angles_RightShoulder;

    [SerializeField] public GameObject RHip;
    public TextAsset RHip_Text;

    [SerializeField] public GameObject LHip;
    public TextAsset LHip_Text;

    [SerializeField] public GameObject LKnee;
    public TextAsset LKnee_Text;

    [SerializeField] public GameObject RKnee;
    public TextAsset RKnee_Text;

    [SerializeField] public GameObject LAnkle;
    public TextAsset LAnkle_Text;

    [SerializeField] public GameObject RAnkle;
    public TextAsset RAnkle_Text;

    [SerializeField] public GameObject LWrist;
    public TextAsset LWrist_Text;

    [SerializeField] public GameObject RWrist;
    public TextAsset RWrist_Text;

    [SerializeField] public GameObject RElbow;
    public TextAsset RElbow_Text;

    [SerializeField] public GameObject LElbow;
    public TextAsset LElbow_Text;
    */

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        readShoulders();
    }

    void readShoulders()
    {
        string[] recordsLeftShoulder = Angles_LeftShoulder.text.Split('\n');
        for (int i = 1; i < recordsLeftShoulder.Length - 1; i++)
        {
            string[] fieldsLeftShoulder = recordsLeftShoulder[i].Split(',');
            LeftShoulder.transform.Rotate(float.Parse(fieldsLeftShoulder[1]), float.Parse(fieldsLeftShoulder[2]), float.Parse(fieldsLeftShoulder[3]));
            //LeftShoulder.transform.position = new Vector3(float.Parse(fieldsLeftShoulder[1]), float.Parse(fieldsLeftShoulder[2]), float.Parse(fieldsLeftShoulder[3]));
        }

        /*string[] recordsRightShoulder = Angles_RightShoulder.text.Split('\n');
        for (int i = 1; i < recordsRightShoulder.Length - 1; i++)
        {
            string[] fieldsRightShoulder = recordsRightShoulder[i].Split(',');
            RightShoulder.transform.Rotate(float.Parse(fieldsRightShoulder[1]), float.Parse(fieldsRightShoulder[2]), float.Parse(fieldsRightShoulder[3]));
            RightShoulder.transform.position = new Vector3(float.Parse(fieldsRightShoulder[1]), float.Parse(fieldsRightShoulder[2]), float.Parse(fieldsRightShoulder[3]));
        }

        string[] chest = Ribs_Text.text.Split('\n');
        for (int i = 1; i < chest.Length - 1; i++)
        {
            string[] fieldsChest = recordsRightShoulder[i].Split(',');
            Ribs.transform.Rotate(float.Parse(fieldsChest[1]), float.Parse(fieldsChest[2]), float.Parse(fieldsChest[3]));
            Ribs.transform.position = new Vector3(float.Parse(fieldsChest[1]), float.Parse(fieldsChest[2]), float.Parse(fieldsChest[3]));
        }
        */
    }

}
