using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtonClicks : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void RestartGame()
    {
        GameEvent.Release();
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
    public void QuitRequest()
    {
        EventGame quitRequest = new(Constant.quitRequest, 0, 0);
        GameEvent.Raise(quitRequest);
    }
    public void MainMenuRequest()
    {
        EventGame mainMenuRequest = new(Constant.mainMenuRequest, 0, 0);
        GameEvent.Raise(mainMenuRequest);
    }
    public void RestartRequest()
    {
        EventGame restartRequest = new(Constant.restartRequest, 0, 0);
        GameEvent.Raise(restartRequest);
    }
    public void CancelQuit()
    {
        EventGame cancelQuit = new(Constant.notQuit, 0, 0);
        GameEvent.Raise(cancelQuit);
    }
    public void CancelMainMenu()
    {
        EventGame cancelMainMenu = new(Constant.notMainMenu, 0, 0);
        GameEvent.Raise(cancelMainMenu);
    }
    public void CancelRestart()
    {
        EventGame cancelRestart = new(Constant.notRestart, 0, 0);
        GameEvent.Raise(cancelRestart);
    }
    public void ResumeGame()
    {
        EventGame resumed = new(Constant.playGame, 0, 0);
        GameEvent.Raise(resumed);
    }
}
