using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class MainMenuControlScriptBGMSFX : MonoBehaviour , IPointerEnterHandler{
    [SerializeField] Button buttonStart;
    [SerializeField] Button buttonOptions;
    [SerializeField] Button buttonCreedits;
    [SerializeField] Button buttonExit;
    
     AudioSource audiosourceButtonUI;
     [SerializeField] AudioClip audioclipHoldOver;
    // Start is called before the first frame update
    void Start()
    {
        this.audiosourceButtonUI = this.gameObject.AddComponent <AudioSource > ();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("UI")[0];
        SetupButtonsDelegate ();
        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
        SingletonSoundManager.Instance.BGMSource.Play();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
        audiosourceButtonUI.Stop ();
        audiosourceButtonUI.PlayOneShot (audioclipHoldOver);
    }
    void SetupButtonsDelegate(){
        buttonStart.onClick.AddListener(delegate{StartButtonClick(buttonStart);});
        buttonOptions.onClick.AddListener ( delegate {OptionsButtonClick(buttonOptions);});
        buttonCreedits.onClick.AddListener ( delegate {CreditsButtonClick(buttonCreedits);});
        buttonExit.onClick.AddListener ( delegate {ExitButtonClick(buttonExit);});
       
    }
    public void StartButtonClick(Button button) {
        SceneManager.LoadScene("SceneStageSelect");
    }
    public void CreditsButtonClick(Button button)
    {
        SceneManager.LoadScene("SceneCredits");
    }
    public void OptionsButtonClick(Button button) {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick(Button button) {
        Application.Quit();
    }
    // Update is called once per frame

}
