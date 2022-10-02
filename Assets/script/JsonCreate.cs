using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Data;
using UnityEngine.SceneManagement;

public class JsonCreate : MonoBehaviour
{
    public WebRequest request;
    public string folderPath;
    public string filePath;
    // Start is called before the first frame update
    void Awake()
    {
        folderPath = (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer ? Application.persistentDataPath : Application.dataPath) + "/myDataFolder/";
        filePath = folderPath + "recolectarCafe1.json";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SaveToJson()
    {
        string jsonSave = JsonUtility.ToJson(request.dataSend, true);
        File.WriteAllText(filePath, jsonSave);
        Debug.Log(filePath);
    }

    public void LoadFromJson()
    {
        string jsonSave = File.ReadAllText(filePath);
        Debug.Log(jsonSave);
        WebRequest.Data data = JsonUtility.FromJson<WebRequest.Data>(jsonSave);
        request.userID = int.Parse(data.userID);
    }

    public string GetPath()
    {

        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath);
        }
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            File.WriteAllText(filePath, "recolectarCafe1.json");
            Debug.Log(filePath);
            SaveToJson();
        }
        else
        {
            SaveToJson();
        }
        SceneManager.LoadScene("SampleScene");
        return filePath;
    }
}
