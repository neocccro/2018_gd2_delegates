using UnityEngine;
using System.Collections;

public class Avatar : MonoBehaviour {


	void Start () {
		GetTexture();
	}

	void GetTexture(){
		// we kunnen de textureloader nu makkelijk hergebruiken. TextureLoader weet helemaal niets van Avatar.cs
		TextureLoader textureLoader = new TextureLoader();
		textureLoader.Load("https://avatars1.githubusercontent.com/u/5459758?s=400&u=128b3183b1cf5c7f9472b875d2d8e615607e720a&v=4",
		                   TextureLoaded,
		                   this); // this verwijst naar dit gameobject
	}

	void TextureLoaded(Texture texture){
		Renderer renderer = GetComponent<Renderer>();
		renderer.material.mainTexture = texture;
	}

}
