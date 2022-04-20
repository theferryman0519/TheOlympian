using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneOpeningLogoB : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image MainBackground;
	public Image DialogueBackground;
	public Text DialogueText;
	public Image OverlayButton;
	public Color OverlayButtonColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color OverlayButtonColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	public Color DialogueTextOriginal = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color DialogueTextAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public ChangeScene Scene02LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		StartCoroutine(FadeDialogueTextIn());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public IEnumerator FadeDialogueTextIn() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			DialogueText.color = Color.Lerp(DialogueTextAlpha, DialogueTextOriginal, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(2.5f);
		Scene02LoadRun.Scene02Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}