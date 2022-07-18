using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public enum GameState
{
    Wait,
    Start,
    QTE,
    End,
    Ulti,
    MainMenu,
    StoryCut,
    Map,
    Menu
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
    public bool pausing;




    public GameState state;
    //主菜单UI
    public Transform mainMenu;

    //临时选技能菜单
    public Transform skillSelectUI;
    public Transform skillDragSlotUI;
    public Transform equipSelectUI;
    public Transform EquipDragSlotUI;



    public Slider imposeBar;


    public Transform InputTipPos;




    public Transform StoryCanvas;

    public Transform bgmask;


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



        state = GameState.MainMenu;
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



        //if (Input.GetKeyDown(KeyCode.R))
        //{

        //    I2.Loc.LocalizationManager.CurrentLanguageCode = "ru";

        //}

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            PlayerPrefs.DeleteAll();

        }



        if (Input.GetKeyDown(KeyCode.Space))
        {


        }





        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausing)
            {
                //Resume();
                //return;
            }



        }

        if (state != GameState.Start && state != GameState.QTE && state != GameState.Ulti)
        {
            return;
        }

        //测试专用键






        //战斗输入按键
        if (Input.GetKeyDown(KeyCode.M))
        {
            //            Debug.Log("INPUT M");
            switch (state)
            {

            }
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {

        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            //           Debug.Log("INPUT X");

        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {

        }

    }
    #endregion

    






    public void NewGame()
    {



    }


    public void ContinueAfterWin()
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









    public void BattleStart()
    {
        state = GameState.Start;
        Pause(GameState.Wait);
    }




    public void Pause(GameState _state)
    {


    }

    public void Resume()
    {
        if (pausing)
        {
            pausing = false;


            state = tempstate;
            Debug.Log("state" + state);
        }

    }



    //
    public void ShowInputTip(string text, int type = 0)
    {


    }


    //危的全屏变暗效果
    //public void BgMaskTransition()
    //{
    //    StartCoroutine(bgmaskeff());
    //}

    //IEnumerator bgmaskeff()
    //{
    //    bgmask.GetComponent<SpriteRenderer>().DOColor(new Color(1, 1, 1, .8f), .5f);
    //    yield return new WaitForSeconds(.5f);
    //    bgmask.GetComponent<SpriteRenderer>().DOColor(new Color(1, 1, 1, 0), .5f);
    //}

    //自动存储进度
    public void AutoSaveData()
    {


    }

    //读取本地进度
    public void LoadData()
    {


    }
}
