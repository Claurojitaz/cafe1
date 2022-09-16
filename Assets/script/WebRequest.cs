using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;
using System;
public class WebRequest : MonoBehaviour
{
    public string userName;
    public int score;
    public int userID;
    public int calificacion;
    [Serializable]
    public struct Data
    {
        public string userName;
        public string score;
        public string userID;
        public string calificacion;
    }
    public Data dataSend;
    public struct GetData
    {
        public string new_user;
        public string assigned_users;
    }
    public GetData varGetData;
    //esta estructura es la que se convierte a json
    private void Start()
    {
        //DataLoadStruct();// se utiliza para enviar la informaci'on
        //DataOnload();
        StartCoroutine(DataOnload());
    }
    //se debe cargar cuando el juego termine
    public void DataLoadStruct()
    {
        dataSend.userName=userName;
        dataSend.score=score.ToString();
        dataSend.userID=userID.ToString();
        dataSend.calificacion = calificacion.ToString();
        StartCoroutine(DataLoad());
    }

    //este metodo pasa la informacion de unity a la estructura data
    IEnumerator DataLoad()
    {
        string json = JsonUtility.ToJson(dataSend);
        var req = new UnityWebRequest("https://m3exmbcq59.execute-api.us-east-2.amazonaws.com/prod/score", "POST");
        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(json);
        req.uploadHandler = (UploadHandler)new UploadHandlerRaw(jsonToSend);
        req.downloadHandler = (DownloadHandler)new DownloadHandlerBuffer();
        req.SetRequestHeader("Content-Type", "application/json");
        //Send the request then wait here until it returns
        yield return req.SendWebRequest();

        if (req.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("Error While Sending: " + req.error);
        }
        else
        {
            Debug.Log("Received: " + req.downloadHandler.text);
        }
    }
    IEnumerator DataOnload()
    {
        UnityWebRequest req = UnityWebRequest.Get("https://m3exmbcq59.execute-api.us-east-2.amazonaws.com/prod/users");
        //Send the request then wait here until it returns
        yield return req.SendWebRequest();

        if (req.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.Log("Error While Sending: " + req.error);
        }
        else
        {
            varGetData = JsonUtility.FromJson<GetData>(req.downloadHandler.text);
            userName = varGetData.new_user;
            Debug.Log("Received: " + req.downloadHandler.text);
        }
    }

}
