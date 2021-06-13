using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class SQLite : MonoBehaviour
{

    public string getTexts()
    {
        string buffer = "Test DB req result";
        //
        //buffer = reqText();
        //
        return buffer;
    }

    public int getLevel()
    {
        int buffer = 0;
        //
        //buffer = reqLevel();
        //
        return buffer;
    }

    private string reqText(IDbConnection dbcon, int id)
    {
        string result = "Test result";
        //

        IDbCommand cmnd_read = dbcon.CreateCommand();

        string query ="SELECT dialogue_text FROM dialogues WHERE dialogue_id = '" + id + "'";
        cmnd_read.CommandText = query;

        IDataReader reader = cmnd_read.ExecuteReader();
        result = reader[0].ToString();

        //
        return result;
    }

    // private int reqLevel()
    // {
    //     int result = 99;
    //     //

        

    //     //
    //     return result;
    // }

    // Start is called before the first frame update
    void Start()
    {
        
        // Создание БД
        string connection = "URI=file:" + Application.dataPath + "/My_Database";
        IDbConnection dbcon = new SqliteConnection(connection);
        dbcon.Open();

        // Создание таблицы
        IDbCommand dbcmd;
        IDataReader reader;

        dbcmd = dbcon.CreateCommand();
        string q_createTable = 
        "CREATE TABLE IF NOT EXISTS dialogues (dialogue_id INTEGER PRIMARY KEY AUTOINCREMENT, theory_id integer, dialogue_text TEXT, FOREIGN KEY (theory_id) REFERENCES theory(theory_id));";
        dbcmd.CommandText = q_createTable;

        reader = dbcmd.ExecuteReader();
        //endof Создание таблицы

        // Внесение строки для проверки
        IDbCommand cmnd = dbcon.CreateCommand();
        cmnd.CommandText = "INSERT INTO dialogues (theory_id, dialogue_text) VALUES (0, 'Dialogue text')";
        cmnd.ExecuteNonQuery();

        // Вывод строки
        Debug.Log("reqText: " + reqText(dbcon, 1));

        dbcon.Close();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
