using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public enum GameState
{
    
}
//统一控制
public class SuperController : MonoBehaviour
{
    //流程
    public string StoryStep = "fresh new";
    public List<string> FinishedStorySteps;

    public GameObject m_Canvas;
    [HideInInspector]


    //在暂停时储存暂停前的状态
    public GameState tempstate;



    //RVC

    //public Village village;
    public List<Clan> clans;




    #region 单例
    static SuperController _instance;
    public static SuperController Instance
    {
        get
        {
            return _instance;
        }
    }
    private void Awake()
    {
        _instance = this;
    }
    #endregion

    // Use this for initialization
    void Start()
    {
        Random.InitState(System.DateTime.Now.Second);



    }

    // Update is called once per frame
    void Update()
    {
        UpdateUI();
        UpdateInput();
    }

    protected void UpdateUI()
    {

    }

    #region 输入控制
    protected void UpdateInput()
    {





    }
    #endregion

    






    public void NewGame()
    {



    }




    public void GameOver()
    {
        //Debug.Log("Game Over");



    }

    IEnumerator GameOverUI()
    {
        yield return new WaitForSeconds(2.0f);


        //mainMenu.gameObject.SetActive(true);
        //mainMenu.Find("Title").GetComponent<Text>().text = "死";
        ////mainMenu.Find("Button").GetComponent<Button>().onClick.AddListener(NewGame);
        //mainMenu.Find("NewGameButton").Find("Text").GetComponent<Text>().text = "再来!";
        //mainMenu.Find("NewGameButton").transform.localScale = Vector3.one;
        //mainMenu.Find("NextButton").transform.localScale = Vector3.zero;
    }
    public void Win()
    {
        //Debug.LogError("Game Over");


        AutoSaveData();
        StartCoroutine("WinUI");
    }
    IEnumerator WinUI()
    {
        yield return new WaitForSeconds(2.0f);



        AutoSaveData();


    }





    //自动存储进度
    public void AutoSaveData()
    {


    }

    //读取本地进度
    public void LoadData()
    {


    }
}
