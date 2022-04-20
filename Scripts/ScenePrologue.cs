using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ScenePrologue : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	public Text DialogueSpeakerText;
	public Text DialogueText;
	public string DialogueString;
	public int PrologueNumber;
	public string PrologueString;
	public int StringCharactersRevealed;
	public bool IsTextFilled;
	public Button OverlayButton;
	public Color OverlayButtonColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color OverlayButtonColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		Button OverlayButtonClick = OverlayButton.GetComponent<Button>();
		OverlayButtonClick.onClick.AddListener(OverlayButtonClicking);

		PrologueNumber = 1;
		IsTextFilled = false;

		OverlayButton.GetComponent<Image>().color = OverlayButtonColorBlack;
		StartCoroutine(FadeOverlayButtonOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		DialogueSpeakerText.text = "Unknown Voice";
		NextDialogue();
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void OverlayButtonClicking() {
		if (IsTextFilled == true) {
			if (PrologueNumber == 1) {
				IsTextFilled = false;
				PrologueNumber = 2;
				PrologueString = "All of us have fled, but some have started to become influenced by the evil of Hades. I have asked Hermes to find you and start a new island chain: Mount " + MainCharacterInformation.HomeNameChoice + ".";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 2) {
				IsTextFilled = false;
				PrologueNumber = 3;
				PrologueString = "Use the skills you have acquired living among humans and help us build our new home. Cultivate the land, befriend the gods, and rid the divine world of evil.";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 3) {
				IsTextFilled = false;
				PrologueNumber = 4;
				PrologueString = "If these tasks can be complete, you will be rewarded by gaining your Olympian status once again...";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 4) {
				IsTextFilled = false;
				PrologueNumber = 5;
				PrologueString = "If we cannot save our culture from this evil, I foresee Hades finding this new home and causing an unimaginable amount of chaos. You must save us...";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 5) {
				IsTextFilled = false;
				PrologueNumber = 6;
				PrologueString = "For now, follow the word of Hermes, and everything will soon fall back into place.";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 6) {
				IsTextFilled = false;
				PrologueNumber = 7;
				PrologueString = "You have always been special in the eyes of humans and of the gods. Now, you must prove it! Open your eyes...";
				DialogueText.text = PrologueString;
				StartCoroutine(FillingOutText());
			}

			else if (PrologueNumber == 7) {
				PrologueNumber = 0;
				StartCoroutine(FadeOverlayButtonIn());
			}
		}
	}

	public void NextDialogue() {
		if (IsTextFilled == true) {
			if (Input.GetKey(KeyCode.Space)) {
				IsTextFilled = false;

				if (PrologueNumber == 1) {
					PrologueNumber = 2;
					PrologueString = "All of us have fled, but some have started to become influenced by the evil of Hades. I have asked Hermes to find you and start a new island chain: Mount " + MainCharacterInformation.HomeNameChoice + ".";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 2) {
					IsTextFilled = false;
					PrologueNumber = 3;
					PrologueString = "Use the skills you have acquired living among humans and help us build our new home. Cultivate the land, befriend the gods, and rid the divine world of evil.";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 3) {
					IsTextFilled = false;
					PrologueNumber = 4;
					PrologueString = "If these tasks can be completed, you will be rewarded by gaining your Olympian status once again...";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 4) {
					IsTextFilled = false;
					PrologueNumber = 5;
					PrologueString = "If we cannot save our culture from this evil, I foresee Hades finding this new home and causing an unimaginable amount of chaos. You must save us...";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 5) {
					IsTextFilled = false;
					PrologueNumber = 6;
					PrologueString = "For now, follow the word of Hermes, and everything will soon fall back into place.";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 6) {
					IsTextFilled = false;
					PrologueNumber = 7;
					PrologueString = "You have always been special in the eyes of humans and of the gods. Now, you must prove it! Open your eyes...";
					DialogueText.text = PrologueString;
					StartCoroutine(FillingOutText());
				}

				else if (PrologueNumber == 7) {
					PrologueNumber = 0;
					StartCoroutine(FadeOverlayButtonIn());
				}
			}
		}
	}

	public IEnumerator FillingOutText() {
		DialogueString = DialogueText.text;
		DialogueText.text = "";

		StringCharactersRevealed = 0;
		while (StringCharactersRevealed < DialogueString.Length) {
			++StringCharactersRevealed;
			DialogueText.text = DialogueString.Substring(0, StringCharactersRevealed);

			yield return new WaitForSeconds(0.04f);
		}

		IsTextFilled = true;
	}

	public IEnumerator FadeOverlayButtonOut() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			OverlayButton.GetComponent<Image>().color = Color.Lerp(OverlayButtonColorBlack, OverlayButtonColorAlpha, ElapsedTime);
			yield return null;
		}

		if (PrologueNumber == 1) {
			if ((MainCharacterInformation.RealmChoice == "Animals") || (MainCharacterInformation.RealmChoice == "Fire")) {
				PrologueString = "You have been away for far too long, " + MainCharacterInformation.PlayerNameChoice + ", " + MainCharacterInformation.GodGoddessChoice + " of " + MainCharacterInformation.RealmChoice + ". Mount Olympus has fallen, and we need you back. Hecate and Ares have teamed up with Hades after wreaking havoc on our home...";
			}

			else {
				PrologueString = "You have been away for far too long, " + MainCharacterInformation.PlayerNameChoice + ", " + MainCharacterInformation.GodGoddessChoice + " of the " + MainCharacterInformation.RealmChoice + ". Mount Olympus has fallen, and we need you back. Hecate and Ares have teamed up with Hades after wreaking havoc on our home...";
			}
		}

		DialogueText.text = PrologueString;
		StartCoroutine(FillingOutText());
	}

	public IEnumerator FadeOverlayButtonIn() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			OverlayButton.GetComponent<Image>().color = Color.Lerp(OverlayButtonColorAlpha, OverlayButtonColorBlack, ElapsedTime);
			yield return null;
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}