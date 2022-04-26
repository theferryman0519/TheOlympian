using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainCharacterProfile : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	// Main Variables
	public Image ProfileBackground;
	public Text MainTitleText;
	public Text SubTitleText;
	public Image AvatarImage;
	public Sprite UnclickedButton;
	public Sprite UnclickedGod;
	public Sprite UnclickedGoddess;
	public Sprite UnclickedPlayerRealmASprite;
	public Sprite UnclickedPlayerRealmBSprite;
	public Sprite UnclickedPlayerRealmCSprite;
	public Sprite UnclickedPlayerRealmDSprite;
	public Sprite UnclickedPlayerRealmESprite;

	// Buttons
	public Button GoBackButton;
	public Button NextButton;
	public Button StartButton;
	public Image GoBackButtonImage;
	public Image NextButtonImage;
	public Image StartButtonImage;

	// Page A
	public Text NameTitleText;
	public Image NameInputField;
	public Text NamePlaceholderText;
	public Text HomeTitleText;
	public Image HomeInputField;
	public Text HomePlaceholderText;
	public Text HomeInputNote;
	public Text GenderTitleText;
	public Button GenderGodButton;
	public Button GenderGoddessButton;
	public Image GenderGodButtonImage;
	public Image GenderGoddessButtonImage;
	public Sprite GenderGodButtonSprite;
	public Sprite GenderGoddessButtonSprite;
	public Text RealmTitleText;
	public Button PlayerRealmA;
	public Button PlayerRealmB;
	public Button PlayerRealmC;
	public Button PlayerRealmD;
	public Button PlayerRealmE;
	public Image PlayerRealmAImage;
	public Image PlayerRealmBImage;
	public Image PlayerRealmCImage;
	public Image PlayerRealmDImage;
	public Image PlayerRealmEImage;
	public Sprite PlayerRealmASprite;
	public Sprite PlayerRealmBSprite;
	public Sprite PlayerRealmCSprite;
	public Sprite PlayerRealmDSprite;
	public Sprite PlayerRealmESprite;

	// Page B
	public Text SkinTitleText;
	public Button SkinToneA;
	public Button SkinToneB;
	public Button SkinToneC;
	public Button SkinToneD;
	public Button SkinToneE;
	public Image SkinToneAImage;
	public Image SkinToneBImage;
	public Image SkinToneCImage;
	public Image SkinToneDImage;
	public Image SkinToneEImage;
	public Sprite SkinToneASprite;
	public Sprite SkinToneBSprite;
	public Sprite SkinToneCSprite;
	public Sprite SkinToneDSprite;
	public Sprite SkinToneESprite;
	public Text EyeTitleText;
	public Button EyeColorA;
	public Button EyeColorB;
	public Button EyeColorC;
	public Button EyeColorD;
	public Button EyeColorE;
	public Button EyeColorF;
	public Button EyeColorG;
	public Button EyeColorH;
	public Image EyeColorAImage;
	public Image EyeColorBImage;
	public Image EyeColorCImage;
	public Image EyeColorDImage;
	public Image EyeColorEImage;
	public Image EyeColorFImage;
	public Image EyeColorGImage;
	public Image EyeColorHImage;
	public Sprite EyeColorASprite;
	public Sprite EyeColorBSprite;
	public Sprite EyeColorCSprite;
	public Sprite EyeColorDSprite;
	public Sprite EyeColorESprite;
	public Sprite EyeColorFSprite;
	public Sprite EyeColorGSprite;
	public Sprite EyeColorHSprite;
	public Text HairTitleText;
	public Button HairColorA;
	public Button HairColorB;
	public Button HairColorC;
	public Button HairColorD;
	public Button HairColorE;
	public Button HairColorF;
	public Button HairColorG;
	public Button HairColorH;
	public Image HairColorAImage;
	public Image HairColorBImage;
	public Image HairColorCImage;
	public Image HairColorDImage;
	public Image HairColorEImage;
	public Image HairColorFImage;
	public Image HairColorGImage;
	public Image HairColorHImage;
	public Sprite HairColorASprite;
	public Sprite HairColorBSprite;
	public Sprite HairColorCSprite;
	public Sprite HairColorDSprite;
	public Sprite HairColorESprite;
	public Sprite HairColorFSprite;
	public Sprite HairColorGSprite;
	public Sprite HairColorHSprite;

	// Page C
	public Text PlayerFullTitle;
	public Text PlayerBonusText;

	// Updated Variables
	public Text NameInputText;
	public Text HomeInputText;

	// Error Page
	public Image ErrorBackground;
	public Image ErrorTextBackground;
	public Text ErrorText;
	public Image ErrorBackButtonImage;
	public Button ErrorBackButton;
	public bool IsError = false;

	// Changing Variables
	public int ProfilePageNumber;
	public Color OverlayColorBlack = new Color(0.0745f, 0.0588f, 0.1019f, 1.0f);
	public Color OverlayColorAlpha = new Color(0.0745f, 0.0588f, 0.1019f, 0.0f);
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	public ChangeScene Scene06LoadRun;
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		ProfilePageNumber = 1;

		Button GoBackButtonClick = GoBackButton.GetComponent<Button>();
		Button NextButtonClick = NextButton.GetComponent<Button>();
		Button StartButtonClick = StartButton.GetComponent<Button>();
		Button GenderGodButtonClick = GenderGodButton.GetComponent<Button>();
		Button GenderGoddessButtonClick = GenderGoddessButton.GetComponent<Button>();
		Button SkinToneAClick = SkinToneA.GetComponent<Button>();
		Button SkinToneBClick = SkinToneB.GetComponent<Button>();
		Button SkinToneCClick = SkinToneC.GetComponent<Button>();
		Button SkinToneDClick = SkinToneD.GetComponent<Button>();
		Button SkinToneEClick = SkinToneE.GetComponent<Button>();
		Button EyeColorAClick = EyeColorA.GetComponent<Button>();
		Button EyeColorBClick = EyeColorB.GetComponent<Button>();
		Button EyeColorCClick = EyeColorC.GetComponent<Button>();
		Button EyeColorDClick = EyeColorD.GetComponent<Button>();
		Button EyeColorEClick = EyeColorE.GetComponent<Button>();
		Button EyeColorFClick = EyeColorF.GetComponent<Button>();
		Button EyeColorGClick = EyeColorG.GetComponent<Button>();
		Button EyeColorHClick = EyeColorH.GetComponent<Button>();
		Button HairColorAClick = HairColorA.GetComponent<Button>();
		Button HairColorBClick = HairColorB.GetComponent<Button>();
		Button HairColorCClick = HairColorC.GetComponent<Button>();
		Button HairColorDClick = HairColorD.GetComponent<Button>();
		Button HairColorEClick = HairColorE.GetComponent<Button>();
		Button HairColorFClick = HairColorF.GetComponent<Button>();
		Button HairColorGClick = HairColorG.GetComponent<Button>();
		Button HairColorHClick = HairColorH.GetComponent<Button>();
		Button PlayerRealmAClick = PlayerRealmA.GetComponent<Button>();
		Button PlayerRealmBClick = PlayerRealmB.GetComponent<Button>();
		Button PlayerRealmCClick = PlayerRealmC.GetComponent<Button>();
		Button PlayerRealmDClick = PlayerRealmD.GetComponent<Button>();
		Button PlayerRealmEClick = PlayerRealmE.GetComponent<Button>();
		Button ErrorBackButtonClick = ErrorBackButton.GetComponent<Button>();

		GoBackButtonClick.onClick.AddListener(GoBackButtonClicking);
		NextButtonClick.onClick.AddListener(NextButtonClicking);
		StartButtonClick.onClick.AddListener(StartButtonClicking);
		GenderGodButtonClick.onClick.AddListener(GenderGodButtonClicking);
		GenderGoddessButtonClick.onClick.AddListener(GenderGoddessButtonClicking);
		SkinToneAClick.onClick.AddListener(SkinToneAClicking);
		SkinToneBClick.onClick.AddListener(SkinToneBClicking);
		SkinToneCClick.onClick.AddListener(SkinToneCClicking);
		SkinToneDClick.onClick.AddListener(SkinToneDClicking);
		SkinToneEClick.onClick.AddListener(SkinToneEClicking);
		EyeColorAClick.onClick.AddListener(EyeColorAClicking);
		EyeColorBClick.onClick.AddListener(EyeColorBClicking);
		EyeColorCClick.onClick.AddListener(EyeColorCClicking);
		EyeColorDClick.onClick.AddListener(EyeColorDClicking);
		EyeColorEClick.onClick.AddListener(EyeColorEClicking);
		EyeColorFClick.onClick.AddListener(EyeColorFClicking);
		EyeColorGClick.onClick.AddListener(EyeColorGClicking);
		EyeColorHClick.onClick.AddListener(EyeColorHClicking);
		HairColorAClick.onClick.AddListener(HairColorAClicking);
		HairColorBClick.onClick.AddListener(HairColorBClicking);
		HairColorCClick.onClick.AddListener(HairColorCClicking);
		HairColorDClick.onClick.AddListener(HairColorDClicking);
		HairColorEClick.onClick.AddListener(HairColorEClicking);
		HairColorFClick.onClick.AddListener(HairColorFClicking);
		HairColorGClick.onClick.AddListener(HairColorGClicking);
		HairColorHClick.onClick.AddListener(HairColorHClicking);
		PlayerRealmAClick.onClick.AddListener(PlayerRealmAClicking);
		PlayerRealmBClick.onClick.AddListener(PlayerRealmBClicking);
		PlayerRealmCClick.onClick.AddListener(PlayerRealmCClicking);
		PlayerRealmDClick.onClick.AddListener(PlayerRealmDClicking);
		PlayerRealmEClick.onClick.AddListener(PlayerRealmEClicking);
		ErrorBackButtonClick.onClick.AddListener(ErrorBackButtonClicking);

		ProfileBackground.enabled = true;
		ProfileBackground.color = OverlayColorBlack;
		StartCoroutine(FadeOverlayOut());
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		ShowHidePages();

		if (IsError == true) {
			ShowErrorPage();
		}

		else {
			HideErrorPage();
		}
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    public void ShowHidePages() {
		if (ProfilePageNumber == 1) {
			// Show Page A
			HideAll();
			ShowPageA();
		}

		else if (ProfilePageNumber == 2) {
			// Show Page B
			HideAll();
			ShowPageB();
		}

		else if (ProfilePageNumber == 3) {
			// Show Page C
			HideAll();
			ShowPageC();
		}
	}

	public void ShowPageA() {
		MainTitleText.enabled = true;
		SubTitleText.enabled = true;
		AvatarImage.enabled = true;
		NextButtonImage.enabled = true;
		NameTitleText.enabled = true;
		NameInputField.enabled = true;
		HomeTitleText.enabled = true;
		HomeInputField.enabled = true;
		HomeInputNote.enabled = true;
		GenderTitleText.enabled = true;
		GenderGodButtonImage.enabled = true;
		GenderGoddessButtonImage.enabled = true;
		RealmTitleText.enabled = true;
		PlayerRealmAImage.enabled = true;
		PlayerRealmBImage.enabled = true;
		PlayerRealmCImage.enabled = true;
		PlayerRealmDImage.enabled = true;
		PlayerRealmEImage.enabled = true;

		if ((NameInputText.text == "") || (NameInputText.text == null)) {
			NamePlaceholderText.enabled = true;
			NameInputText.enabled = false;
		}

		else {
			NamePlaceholderText.enabled = false;
			NameInputText.enabled = true;
		}

		if ((HomeInputText.text == "") || (HomeInputText.text == null)) {
			HomePlaceholderText.enabled = true;
			HomeInputText.enabled = false;
		}

		else {
			HomePlaceholderText.enabled = false;
			HomeInputText.enabled = true;
		}
	}

	public void ShowPageB() {
		MainTitleText.enabled = true;
		SubTitleText.enabled = true;
		AvatarImage.enabled = true;
		GoBackButtonImage.enabled = true;
		NextButtonImage.enabled = true;
		SkinTitleText.enabled = true;
		SkinToneAImage.enabled = true;
		SkinToneBImage.enabled = true;
		SkinToneCImage.enabled = true;
		SkinToneDImage.enabled = true;
		SkinToneEImage.enabled = true;
		EyeTitleText.enabled = true;
		EyeColorAImage.enabled = true;
		EyeColorBImage.enabled = true;
		EyeColorCImage.enabled = true;
		EyeColorDImage.enabled = true;
		EyeColorEImage.enabled = true;
		EyeColorFImage.enabled = true;
		EyeColorGImage.enabled = true;
		EyeColorHImage.enabled = true;
		HairTitleText.enabled = true;
		HairColorAImage.enabled = true;
		HairColorBImage.enabled = true;
		HairColorCImage.enabled = true;
		HairColorDImage.enabled = true;
		HairColorEImage.enabled = true;
		HairColorFImage.enabled = true;
		HairColorGImage.enabled = true;
		HairColorHImage.enabled = true;
	}

	public void ShowPageC() {
		MainTitleText.enabled = true;
		SubTitleText.enabled = true;
		AvatarImage.enabled = true;
		GoBackButtonImage.enabled = true;
		StartButtonImage.enabled = true;

		if ((MainCharacterInformation.RealmChoice == "") || (MainCharacterInformation.RealmChoice == null)) {
			PlayerFullTitle.enabled = false;
			PlayerBonusText.enabled = false;
		}

		else {
			if ((MainCharacterInformation.RealmChoice == "Animals") || (MainCharacterInformation.RealmChoice == "Fire")) {
				PlayerFullTitle.enabled = true;
				PlayerFullTitle.text = MainCharacterInformation.PlayerNameChoice + "\n" + MainCharacterInformation.GodGoddessChoice + " of " + MainCharacterInformation.RealmChoice;
				PlayerBonusText.enabled = true;
			}

			else {
				PlayerFullTitle.enabled = true;
				PlayerFullTitle.text = MainCharacterInformation.PlayerNameChoice + "\n" + MainCharacterInformation.GodGoddessChoice + " of the " + MainCharacterInformation.RealmChoice;
				PlayerBonusText.enabled = true;
			}
		}

		if (MainCharacterInformation.RealmChoice == "Animals") {
			PlayerBonusText.text = "Player Bonus: When fishing, every Fish gathered is tripled in amount.";
		}

		else if (MainCharacterInformation.RealmChoice == "Fire") {
			PlayerBonusText.text = "Player Bonus: When breaking rocks, all Obsidian found is tripled in amount and all Iron is doubled.";
		}

		else if (MainCharacterInformation.RealmChoice == "Land") {
			PlayerBonusText.text = "Player Bonus: When harvesting crops, all Wheat, Olives, and Grapes gathered are doubled per single seed.";
		}

		else if (MainCharacterInformation.RealmChoice == "Skies") {
			PlayerBonusText.text = "Player Bonus: When welcoming gods, all Olympians except Hermes start with +5 Friendship.";
		}

		else if (MainCharacterInformation.RealmChoice == "Water") {
			PlayerBonusText.text = "Player Bonus: When traveling across rivers, Charon's Ferryman Fee costs 2 less Coins.";
		}
	}

	public void ShowErrorPage() {
		ErrorBackground.enabled = true;
		ErrorTextBackground.enabled = true;
		ErrorText.enabled = true;
		ErrorBackButtonImage.enabled = true;
	}

	public void HideAll() {
		// Main
		MainTitleText.enabled = false;
		SubTitleText.enabled = false;
		AvatarImage.enabled = false;
		GoBackButtonImage.enabled = false;
		NextButtonImage.enabled = false;
		StartButtonImage.enabled = false;

		// Page A
		NameTitleText.enabled = false;
		NameInputField.enabled = false;
		NamePlaceholderText.enabled = false;
		NameInputText.enabled = false;
		HomeTitleText.enabled = false;
		HomeInputField.enabled = false;
		HomePlaceholderText.enabled = false;
		HomeInputText.enabled = false;
		HomeInputNote.enabled = false;
		GenderTitleText.enabled = false;
		GenderGodButtonImage.enabled = false;
		GenderGoddessButtonImage.enabled = false;
		RealmTitleText.enabled = false;
		PlayerRealmAImage.enabled = false;
		PlayerRealmBImage.enabled = false;
		PlayerRealmCImage.enabled = false;
		PlayerRealmDImage.enabled = false;
		PlayerRealmEImage.enabled = false;

		// Page B
		SkinTitleText.enabled = false;
		SkinToneAImage.enabled = false;
		SkinToneBImage.enabled = false;
		SkinToneCImage.enabled = false;
		SkinToneDImage.enabled = false;
		SkinToneEImage.enabled = false;
		EyeTitleText.enabled = false;
		EyeColorAImage.enabled = false;
		EyeColorBImage.enabled = false;
		EyeColorCImage.enabled = false;
		EyeColorDImage.enabled = false;
		EyeColorEImage.enabled = false;
		EyeColorFImage.enabled = false;
		EyeColorGImage.enabled = false;
		EyeColorHImage.enabled = false;
		HairTitleText.enabled = false;
		HairColorAImage.enabled = false;
		HairColorBImage.enabled = false;
		HairColorCImage.enabled = false;
		HairColorDImage.enabled = false;
		HairColorEImage.enabled = false;
		HairColorFImage.enabled = false;
		HairColorGImage.enabled = false;
		HairColorHImage.enabled = false;

		// Page C
		PlayerFullTitle.enabled = false;
		PlayerBonusText.enabled = false;

		HideErrorPage();
	}

	public void HideErrorPage() {
		ErrorBackground.enabled = false;
		ErrorTextBackground.enabled = false;
		ErrorText.enabled = false;
		ErrorBackButtonImage.enabled = false;
	}

	public void GoBackButtonClicking() {
		if (ProfilePageNumber == 2) {
			ProfilePageNumber = 1;
		}

		else if (ProfilePageNumber == 3) {
			ProfilePageNumber = 2;
		}
	}

	public void NextButtonClicking() {
		if (ProfilePageNumber == 1) {
			string NameInputString = NameInputText.text;
			string HomeInputString = HomeInputText.text;
			MainCharacterInformation.PlayerNameChoice = NameInputString.Substring(0,1).ToUpper() + NameInputString.Substring(1);
			MainCharacterInformation.HomeNameChoice = HomeInputString.Substring(0,1).ToUpper() + HomeInputString.Substring(1);
			ProfilePageNumber = 2;
		}

		else if (ProfilePageNumber == 2) {
			ProfilePageNumber = 3;
		}
	}

	public void ErrorBackButtonClicking() {
		IsError = false;
	}
	
	public void StartButtonClicking() {
		if (ProfilePageNumber == 3) {
			if ((MainCharacterInformation.PlayerNameChoice == "") || (MainCharacterInformation.HomeNameChoice == "") || (MainCharacterInformation.GodGoddessChoice == "") || (MainCharacterInformation.RealmChoice == "") || (MainCharacterAppearance.SkinToneHex == "") || (MainCharacterAppearance.EyeColorHex == "") || (MainCharacterAppearance.HairColorHex == "")) {
				IsError = true;
			}

			else {
				ProfileBackground.enabled = true;
				StartCoroutine(FadeOverlayIn());
			}
		}
	}
	
	public void GenderGodButtonClicking() {
		GenderGoddessButtonImage.sprite = UnclickedGoddess;
		GenderGodButtonImage.sprite = GenderGodButtonSprite;
		MainCharacterInformation.GodGoddessChoice = "God";
	}
	
	public void GenderGoddessButtonClicking() {
		GenderGoddessButtonImage.sprite = GenderGoddessButtonSprite;
		GenderGodButtonImage.sprite = UnclickedGod;
		MainCharacterInformation.GodGoddessChoice = "Goddess";
	}
	
	public void SkinToneAClicking() {
		SkinToneAImage.sprite = SkinToneASprite;
		SkinToneBImage.sprite = UnclickedButton;
		SkinToneCImage.sprite = UnclickedButton;
		SkinToneDImage.sprite = UnclickedButton;
		SkinToneEImage.sprite = UnclickedButton;
		MainCharacterAppearance.SkinToneHex = "#ffdbac";
	}
	
	public void SkinToneBClicking() {
		SkinToneAImage.sprite = UnclickedButton;
		SkinToneBImage.sprite = SkinToneBSprite;
		SkinToneCImage.sprite = UnclickedButton;
		SkinToneDImage.sprite = UnclickedButton;
		SkinToneEImage.sprite = UnclickedButton;
		MainCharacterAppearance.SkinToneHex = "#f1c27d";
	}
	
	public void SkinToneCClicking() {
		SkinToneAImage.sprite = UnclickedButton;
		SkinToneBImage.sprite = UnclickedButton;
		SkinToneCImage.sprite = SkinToneCSprite;
		SkinToneDImage.sprite = UnclickedButton;
		SkinToneEImage.sprite = UnclickedButton;
		MainCharacterAppearance.SkinToneHex = "#e0ac69";
	}
	
	public void SkinToneDClicking() {
		SkinToneAImage.sprite = UnclickedButton;
		SkinToneBImage.sprite = UnclickedButton;
		SkinToneCImage.sprite = UnclickedButton;
		SkinToneDImage.sprite = SkinToneDSprite;
		SkinToneEImage.sprite = UnclickedButton;
		MainCharacterAppearance.SkinToneHex = "#c68642";
	}
	
	public void SkinToneEClicking() {
		SkinToneAImage.sprite = UnclickedButton;
		SkinToneBImage.sprite = UnclickedButton;
		SkinToneCImage.sprite = UnclickedButton;
		SkinToneDImage.sprite = UnclickedButton;
		SkinToneEImage.sprite = SkinToneESprite;
		MainCharacterAppearance.SkinToneHex = "#8d5524";
	}
	
	public void EyeColorAClicking() {
		EyeColorAImage.sprite = EyeColorASprite;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#593200";
	}
	
	public void EyeColorBClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = EyeColorBSprite;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#030201";
	}
	
	public void EyeColorCClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = EyeColorCSprite;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#027d02";
	}
	
	public void EyeColorDClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = EyeColorDSprite;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#036db8";
	}
	
	public void EyeColorEClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = EyeColorESprite;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#b80303";
	}
	
	public void EyeColorFClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = EyeColorFSprite;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#c3c508";
	}
	
	public void EyeColorGClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = EyeColorGSprite;
		EyeColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.EyeColorHex = "#7907a8";
	}
	
	public void EyeColorHClicking() {
		EyeColorAImage.sprite = UnclickedButton;
		EyeColorBImage.sprite = UnclickedButton;
		EyeColorCImage.sprite = UnclickedButton;
		EyeColorDImage.sprite = UnclickedButton;
		EyeColorEImage.sprite = UnclickedButton;
		EyeColorFImage.sprite = UnclickedButton;
		EyeColorGImage.sprite = UnclickedButton;
		EyeColorHImage.sprite = EyeColorHSprite;
		MainCharacterAppearance.EyeColorHex = "#7b7b7b";
	}
	
	public void HairColorAClicking() {
		HairColorAImage.sprite = HairColorASprite;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#593200";
	}
	
	public void HairColorBClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = HairColorBSprite;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#030201";
	}
	
	public void HairColorCClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = HairColorCSprite;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#027d02";
	}
	
	public void HairColorDClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = HairColorDSprite;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#036db8";
	}
	
	public void HairColorEClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = HairColorESprite;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#b80303";
	}
	
	public void HairColorFClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = HairColorFSprite;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#c3c508";
	}
	
	public void HairColorGClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = HairColorGSprite;
		HairColorHImage.sprite = UnclickedButton;
		MainCharacterAppearance.HairColorHex = "#7907a8";
	}
	
	public void HairColorHClicking() {
		HairColorAImage.sprite = UnclickedButton;
		HairColorBImage.sprite = UnclickedButton;
		HairColorCImage.sprite = UnclickedButton;
		HairColorDImage.sprite = UnclickedButton;
		HairColorEImage.sprite = UnclickedButton;
		HairColorFImage.sprite = UnclickedButton;
		HairColorGImage.sprite = UnclickedButton;
		HairColorHImage.sprite = HairColorHSprite;
		MainCharacterAppearance.HairColorHex = "#7b7b7b";
	}
	
	public void PlayerRealmAClicking() {
		PlayerRealmAImage.sprite = PlayerRealmASprite;
		PlayerRealmBImage.sprite = UnclickedPlayerRealmBSprite;
		PlayerRealmCImage.sprite = UnclickedPlayerRealmCSprite;
		PlayerRealmDImage.sprite = UnclickedPlayerRealmDSprite;
		PlayerRealmEImage.sprite = UnclickedPlayerRealmESprite;
		MainCharacterAppearance.TogaColorHex = "#7907a8";
		MainCharacterInformation.RealmChoice = "Animals";
	}
	
	public void PlayerRealmBClicking() {
		PlayerRealmAImage.sprite = UnclickedPlayerRealmASprite;
		PlayerRealmBImage.sprite = PlayerRealmBSprite;
		PlayerRealmCImage.sprite = UnclickedPlayerRealmCSprite;
		PlayerRealmDImage.sprite = UnclickedPlayerRealmDSprite;
		PlayerRealmEImage.sprite = UnclickedPlayerRealmESprite;
		MainCharacterAppearance.TogaColorHex = "#b80303";
		MainCharacterInformation.RealmChoice = "Fire";
	}
	
	public void PlayerRealmCClicking() {
		PlayerRealmAImage.sprite = UnclickedPlayerRealmASprite;
		PlayerRealmBImage.sprite = UnclickedPlayerRealmBSprite;
		PlayerRealmCImage.sprite = PlayerRealmCSprite;
		PlayerRealmDImage.sprite = UnclickedPlayerRealmDSprite;
		PlayerRealmEImage.sprite = UnclickedPlayerRealmESprite;
		MainCharacterAppearance.TogaColorHex = "#027d02";
		MainCharacterInformation.RealmChoice = "Land";
	}
	
	public void PlayerRealmDClicking() {
		PlayerRealmAImage.sprite = UnclickedPlayerRealmASprite;
		PlayerRealmBImage.sprite = UnclickedPlayerRealmBSprite;
		PlayerRealmCImage.sprite = UnclickedPlayerRealmCSprite;
		PlayerRealmDImage.sprite = PlayerRealmDSprite;
		PlayerRealmEImage.sprite = UnclickedPlayerRealmESprite;
		MainCharacterAppearance.TogaColorHex = "#c3c508";
		MainCharacterInformation.RealmChoice = "Skies";
	}
	
	public void PlayerRealmEClicking() {
		PlayerRealmAImage.sprite = UnclickedPlayerRealmASprite;
		PlayerRealmBImage.sprite = UnclickedPlayerRealmBSprite;
		PlayerRealmCImage.sprite = UnclickedPlayerRealmCSprite;
		PlayerRealmDImage.sprite = UnclickedPlayerRealmDSprite;
		PlayerRealmEImage.sprite = PlayerRealmESprite;
		MainCharacterAppearance.TogaColorHex = "#036db8";
		MainCharacterInformation.RealmChoice = "Water";
	}

	public IEnumerator FadeOverlayOut() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			ProfileBackground.GetComponent<Image>().color = Color.Lerp(OverlayColorBlack, OverlayColorAlpha, ElapsedTime);
			yield return null;
		}

		ProfileBackground.enabled = false;
	}

	public IEnumerator FadeOverlayIn() {
		float ElapsedTime = 0f;

		while (ElapsedTime < 1.5f) {
			ElapsedTime += Time.deltaTime;
			ProfileBackground.GetComponent<Image>().color = Color.Lerp(OverlayColorAlpha, OverlayColorBlack, ElapsedTime);
			yield return null;
		}

		Scene06LoadRun.Scene06Load();
	}
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}