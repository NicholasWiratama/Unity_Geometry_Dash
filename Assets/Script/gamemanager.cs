using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{   
    
    private Vector2[] Obs1 = {
        new Vector2(-12f,3f),
        new Vector2(-4.4f,-2.7f)
    };
    private Vector2[] Obs2 = {
        new Vector2(-2f,6f),
        new Vector2(-11f,-4.3f)
    };
    private Vector2[] Obs3 = {
        new Vector2(7f,-7f),
        new Vector2(8.3f,6f)
    };
    private Vector2[] Obs4 = {
        new Vector2(15f,3f),
        new Vector2(13.8f,6.6f)
    };
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject ob4;
    int random;
    public GameObject startPos;
    // public bool loop;
    // public float distance = 0.2f;



    public void RPmap(){
        random = Random.Range(0,5);
        ob1.transform.position = Obs1[random];
        ob2.transform.position = Obs2[random];
        ob3.transform.position = Obs3[random];
        ob4.transform.position = Obs4[random];
    }

    private void Start(){

        //startPos = GameObject.Find("Spawn").gameObject;
      
    }

    public void Loop(){
        RPmap();
        //this.gameObject.transform.position= new Vector2(startPos.transform.position.x ,this.gameObject.transform.position.y);
        
    }

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}