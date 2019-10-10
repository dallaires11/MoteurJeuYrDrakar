using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class BDStart : MonoBehaviour
{
    public GameObject firstTextObject;
    public GameObject secondTextObject;
    public GameObject thirdTextObject;
    // Start is called before the first frame update
    void Start()
    {

        string conn = "URI=file:" + Application.dataPath + "/YrDraker.db";

        Debug.Log("Test");
        
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();

        string sqlQuery = "SELECT Nom,Points, Position " + "FROM LeaderBoard WHERE Position < 4 ORDER BY Position ASC";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();
        int x = 0;
        Text test = null;
        while (reader.Read())
        {
            string nom = reader.GetString(0);
            int points = reader.GetInt32(1);
            int position = reader.GetInt32(2);

            if (x==0)
                test = firstTextObject.GetComponent<Text>();
            else if (x==1)
                test = secondTextObject.GetComponent<Text>();
            else if (x==2)
                test = thirdTextObject.GetComponent<Text>();

            test.text = position +". "+nom+" - "+points;

            Debug.Log("Nom= " + nom + "  Points =" + points + "  Position =" + position);
            x++;
        }
        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
    }
}
