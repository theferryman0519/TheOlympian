using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneOpeningLogoA : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Image MainBackground;
	public Image DialogueBackground;
	public Image FerrymanLogo;
	public Image OverlayButton;
	public Color OverlayButtonColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color OverlayButtonColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	public Color FerrymanLogoOriginal = new Color(1.0f, 1.0f, 1.0f, 1.0f);
	public Color FerrymanLogoAlpha = new Color(1.0f, 1.0f, 1.0f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public ChangeScene Scene01LoadRun;
	public ChangeScene Scene02LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		StartCoroutine(FadeOverlayButtonOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
	public IEnumerator FadeOverlayButtonOut() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 2.5f) {
			ElapsedTime += Time.deltaTime;
			OverlayButton.GetComponent<Image>().color = Color.Lerp(OverlayButtonColorBlack, OverlayButtonColorAlpha, ElapsedTime);
			yield return null;
		}

		yield return new WaitForSeconds(2.5f);
		StartCoroutine(FadeFerrymanLogoOut());
	}

	public IEnumerator FadeFerrymanLogoOut() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 2.5f) {
			ElapsedTime += Time.deltaTime;
			FerrymanLogo.GetComponent<Image>().color = Color.Lerp(FerrymanLogoOriginal, FerrymanLogoAlpha, ElapsedTime);
			yield return null;
		}

		Scene01LoadRun.Scene01Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}