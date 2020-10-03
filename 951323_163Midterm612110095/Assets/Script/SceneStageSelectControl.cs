using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneStageSelectControl : MonoBehaviour
{
    [SerializeField] Button _backButton;
    [SerializeField] Button _stage1;
    [SerializeField] Button _stage2;
    // Start is called before the first frame update
    void Start()
    {
        _backButton.onClick.AddListener
        (delegate { BackToMainMenuButtonClick(_backButton); });
        _stage1.onClick.AddListener
        (delegate{Stage1ButtonClick(_stage1);});
        _stage2.onClick.AddListener
        (delegate{Stage2ButtonClick(_stage2);});
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackToMainMenuButtonClick(Button button) {
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneMainmenu");
    }
    public void Stage1ButtonClick(Button button){
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage1");
    }
    public void Stage2ButtonClick(Button button){
        SceneManager.UnloadSceneAsync("SceneStageSelect");
        SceneManager.LoadScene("SceneStage1");
    }
}
