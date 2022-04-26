using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneHomeScreen : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image MainBackground;
	public Image DialogueBackground;
	public Text DialogueText;
	public Button NewGameButton;
	public Image OverlayBackground;
	public Image NewGameOverlay;
	public Color OverlayBackgroundColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color OverlayBackgroundColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	public Color NewGameOverlayColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color NewGameOverlayColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public ChangeScene Scene05LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button NewGameButtonClick = NewGameButton.GetComponent<Button>();
		NewGameButtonClick.onClick.AddListener(NewGameButtonClicking);

		StartCoroutine(FadeOverlayBackgroundOut());
		NewGameOverlay.color = NewGameOverlayColorAlpha;
		NewGameOverlay.enabled = false;
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void NewGameButtonClicking() {
		NewGameOverlay.enabled = true;
		StartCoroutine(FadeNewGameOverlayIn());
	}

	public IEnumerator FadeOverlayBackgroundOut() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 2.5f) {
			ElapsedTime += Time.deltaTime;
			OverlayBackground.GetComponent<Image>().color = Color.Lerp(OverlayBackgroundColorBlack, OverlayBackgroundColorAlpha, ElapsedTime);
			yield return null;
		}

		OverlayBackground.enabled = false;
	}

	public IEnumerator FadeNewGameOverlayIn() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			NewGameOverlay.GetComponent<Image>().color = Color.Lerp(NewGameOverlayColorAlpha, NewGameOverlayColorBlack, ElapsedTime);
			yield return null;
		}

		Scene05LoadRun.Scene05Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}