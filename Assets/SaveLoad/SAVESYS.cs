using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SAVESYS
{
    //Save System
    public static void SaveDATA(AllInfor allinfor)
    {

        Debug.LogWarning("SAVEYSY");
        string path = Application.persistentDataPath + "/sys.save";
        FileStream file;
        if (File.Exists(path)) file = File.OpenWrite(path);
        else file = File.Create(path);
        InforDATA DATA = new InforDATA(allinfor);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(file, DATA);
        file.Close();


    }


    //Load Systeam
    public static InforDATA LoadDATA()
    {
        string path = Application.persistentDataPath + "/sys.save";

        if (File.Exists(path))
        {
            Debug.Log(" Co File Save");
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            InforDATA datablood = formatter.Deserialize(stream) as InforDATA;
            stream.Close();
            return datablood;


        }
        else
        {

            FileStream file;
            file = File.Create(path);
            InforDATA data = new InforDATA();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(file, data);
            file.Close();
            return data;

        }
    }
}
