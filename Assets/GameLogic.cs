using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour {

    public enum GameState
    {
        None,
        Start,
        Pause,
        End
    }

    private StageGenerator _stateGenerator;//路径生成器

    /**游戏初始化*/
    public void GameInit()
    {
        _stateGenerator = this.gameObject.GetComponent<StageGenerator>();
        //需要处理排名记录
    }

    /**游戏开始*/
    public void GameReStart()
    {

    }

    /**游戏暂停*/
    public void GamePause()
    {
        Time.timeScale = 0;
    }

    /**游戏暂停恢复*/
    public void GameAwake()
    {
        Time.timeScale = 1;
    }

    /**游戏结束*/
    public void GameEnd()
    {
        //需要处理排名记录
        Application.Quit();      
    }

    // Use this for initialization
    void Start ()
    {
        GameInit();
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
