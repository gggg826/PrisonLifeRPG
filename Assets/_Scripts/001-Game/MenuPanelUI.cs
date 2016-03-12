/*****************************
*
*  Author : TheNO.5
*
******************************/


using UnityEngine;
using UnityEngine.UI;

public class MenuPanelUI : BasePaPerTween
{
    private Button musicOn;
    private Button musicOff;
    private Button exitGame;

    void Start()
    {
        base.BaseInit();
        musicOn = transform.Find("Image_musicOn").GetComponent<Button>();
        musicOff = transform.Find("Image_musicOff").GetComponent<Button>();
        exitGame = transform.Find("Image_ExitGame").GetComponent<Button>();
        exitGame.onClick.AddListener(delegate { ExitGame(); });
    }

    void ExitGame()
    {
        Application.LoadLevel(0);
    }

    public void ShowPanel()
    {
        base.UP();
    }

    protected override void HidePanel()
    {
        base.DOWN();
    }
}