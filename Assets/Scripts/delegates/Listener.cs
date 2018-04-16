using UnityEngine;

public class Listener : MonoBehaviour
{

	private SoundPlayer soundPlayer;

	void Awake () 
	{
		// Deze Class wil weten wanneer het geluid klaar is met spelen
		// daarvoor registreert hij zich voor de OnSoundCompleted Event / CallBack
		soundPlayer = GameObject.Find ("SoundPlayer").GetComponent<SoundPlayer>();
		soundPlayer.SoundCompleted += OnSoundComplete;
	}

	void OnSoundComplete()
	{
		print ("ik zie dat het geluid klaar is met spelen: " + this.name);
	}

	void OnMouseDown(){
		soundPlayer.PlaySound();
	}

	

}