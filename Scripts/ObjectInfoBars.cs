using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class ObjectInfoBars : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
// Dialogue
	public Image DialogueBackground;
	public Image DialogueSpeakerBackground;
	public Text DialogueSpeakerText;
	public Text DialogueText;
	public Text DialogueNextText;

// Divine Bag
	public Image DivineBagBackground;
	public Image DivineBagCategoryAImage;
	public Image DivineBagCategoryBImage;
	public Image DivineBagCategoryCImage;
	public Image DivineBagCategoryDImage;
	public Image DivineBagCategoryEImage;
	public Button DivineBagCategoryAButton;
	public Button DivineBagCategoryBButton;
	public Button DivineBagCategoryCButton;
	public Button DivineBagCategoryDButton;
	public Button DivineBagCategoryEButton;
	public Image DivineBagTitleBackground;
	public Text DivineBagTitle;
	public Image DivineBagCloseImage;
	public Button DivineBagCloseButton;

// Divine Bag Interior
	public Image InteriorBackground;
	public Image InteriorTitleBackgroundBackground;
	public Text InteriorTitle;
	public Image InteriorCloseImage;
	public Image InteriorBackImage;
	public Button InteriorCloseButton;
	public Button InteriorBackButton;

// Upper Bar
	public Image UpperBarBackground;
	public Text UpperBarDateText;
	public Text UpperBarTimeText;
	public Text UpperBarLightText;
	public Text UpperBarLocationText;
	public Image LowerUpperBarBackground;
	public Text LowerUpperBarInteractText;

// Lower Bar
	public Image LowerbarBackground;
	public Text LowerBarDivineBagText;
	public Image LowerBarDivineBagImage;
	public Button LowerBarDivineBagButton;
	public Text LowerBarGEJarText;
	public Image LowerBarGEJarImage;
	public Button LowerBarGEJarButton;
	public Text LowerBarCoinsText;
	public Image LowerBarCoinsImage;
	public Button LowerBarCoinsButton;
	public Text LowerBarGameMenuText;
	public Image LowerBarGameMenuImage;
	public Button LowerBarGameMenuButton;

// Middle Bar
	public Image MiddleBarBackground;
	public Text MiddleBarIntroText;

// Overlay Button
	public Image OverlayImage;
	public Button OverlayButton;

// Show / Hide Int
	public int ShowHideInfoBars = 0;
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		// LowerBarDivineBagButton
		Button LowerBarDivineBagButtonClick = LowerBarDivineBagButton.GetComponent<Button>();
		LowerBarDivineBagButtonClick.onClick.AddListener(LowerBarDivineBagButtonClicking);

		// DivineBagCloseButton
		Button DivineBagCloseButtonClick = DivineBagCloseButton.GetComponent<Button>();
		DivineBagCloseButtonClick.onClick.AddListener(DivineBagCloseButtonClicking);
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		ShowHideDialogue();
		ShowHideDivineBag();
		ShowHideDivineBagInterior();
		ShowHideMiddleBar();
		ShowHideInteractBar();
		CheckingKeyboardButtons();

		if (ShowHideInfoBars > 0) {
			PlayerSaveDataPoints.PlayerTimePaused = true;
		}

		else if (ShowHideInfoBars == 0) {
			PlayerSaveDataPoints.PlayerTimePaused = false;
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void ShowHideDialogue() {
		if (ShowHideInfoBars == 1) {
			DialogueBackground.enabled = true;
			DialogueSpeakerBackground.enabled = true;
			DialogueSpeakerText.enabled = true;
			DialogueText.enabled = true;
			DialogueNextText.enabled = true;
			OverlayImage.enabled = true;
			OverlayButton.enabled = true;
		}

		else {
			DialogueBackground.enabled = false;
			DialogueSpeakerBackground.enabled = false;
			DialogueSpeakerText.enabled = false;
			DialogueText.enabled = false;
			DialogueNextText.enabled = false;
			OverlayImage.enabled = false;
			OverlayButton.enabled = false;
		}
	}

	public void ShowHideDivineBag() {
		if (ShowHideInfoBars == 2) {
			DivineBagBackground.enabled = true;
			DivineBagCategoryAImage.enabled = true;
			DivineBagCategoryBImage.enabled = true;
			DivineBagCategoryCImage.enabled = true;
			DivineBagCategoryDImage.enabled = true;
			DivineBagCategoryEImage.enabled = true;
			DivineBagCategoryAButton.enabled = true;
			DivineBagCategoryBButton.enabled = true;
			DivineBagCategoryCButton.enabled = true;
			DivineBagCategoryDButton.enabled = true;
			DivineBagCategoryEButton.enabled = true;
			DivineBagTitleBackground.enabled = true;
			DivineBagTitle.enabled = true;
			DivineBagCloseImage.enabled = true;
			DivineBagCloseButton.enabled = true;
		}

		else {
			DivineBagBackground.enabled = false;
			DivineBagCategoryAImage.enabled = false;
			DivineBagCategoryBImage.enabled = false;
			DivineBagCategoryCImage.enabled = false;
			DivineBagCategoryDImage.enabled = false;
			DivineBagCategoryEImage.enabled = false;
			DivineBagCategoryAButton.enabled = false;
			DivineBagCategoryBButton.enabled = false;
			DivineBagCategoryCButton.enabled = false;
			DivineBagCategoryDButton.enabled = false;
			DivineBagCategoryEButton.enabled = false;
			DivineBagTitleBackground.enabled = false;
			DivineBagTitle.enabled = false;
			DivineBagCloseImage.enabled = false;
			DivineBagCloseButton.enabled = false;
		}
	}

	public void ShowHideDivineBagInterior() {
		if (ShowHideInfoBars == 3) {
			InteriorBackground.enabled = true;
			InteriorTitleBackgroundBackground.enabled = true;
			InteriorTitle.enabled = true;
			InteriorCloseImage.enabled = true;
			InteriorBackImage.enabled = true;
			InteriorCloseButton.enabled = true;
			InteriorBackButton.enabled = true;
		}

		else {
			InteriorBackground.enabled = false;
			InteriorTitleBackgroundBackground.enabled = false;
			InteriorTitle.enabled = false;
			InteriorCloseImage.enabled = false;
			InteriorBackImage.enabled = false;
			InteriorCloseButton.enabled = false;
			InteriorBackButton.enabled = false;
		}
	}

	public void ShowHideMiddleBar() {
		if (ShowHideInfoBars == 4) {
			MiddleBarBackground.enabled = true;
			MiddleBarIntroText.enabled = true;
		}

		else {
			MiddleBarBackground.enabled = false;
			MiddleBarIntroText.enabled = false;
		}
	}

	public void ShowHideInteractBar() {
		if (ShowHideInfoBars == 5) {
			LowerUpperBarBackground.enabled = true;
			LowerUpperBarInteractText.enabled = true;
		}

		else {
			LowerUpperBarBackground.enabled = false;
			LowerUpperBarInteractText.enabled = false;
		}
	}

	public void LowerBarDivineBagButtonClicking() {
		ShowHideInfoBars = 2;
	}

	public void DivineBagCloseButtonClicking() {
		ShowHideInfoBars = 0;
	}

	public void CheckingKeyboardButtons() {
		if (Input.GetKey(KeyCode.Tab)) {
			if (ShowHideInfoBars == 0) {
				ShowHideInfoBars = 2;
			}

			else if (ShowHideInfoBars == 2) {
				ShowHideInfoBars = 0;
			}
		}
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}