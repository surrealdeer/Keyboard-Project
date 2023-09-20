using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class secondScene : MonoBehaviour
{

    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;

    void Start()
    {
        string PlayerName = PlayerPrefs.GetString("PlayerName");
        string PlayerSurname = PlayerPrefs.GetString("PlayerSurname");
        string playerID = PlayerPrefs.GetString("PlayerID");

        Debug.Log("PlayerName" + PlayerName);
        Debug.Log("PlayerSurname" + PlayerSurname);
        Debug.Log("playerID" +  playerID);

        text1.text = PlayerName;
        text2.text = PlayerSurname;
        text3.text = playerID;

    }

    void Update()
    {
        
    }
}
