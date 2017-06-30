using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QRGenExample : MonoBehaviour {

	public RawImage qrImageView;

	void Start () {
		string inputText = "http://google.com";
		Texture2D texture = new Texture2D (256, 256);
		qrImageView.texture = texture;
		QRGen.Instance.create (inputText,(Texture2D)qrImageView.texture);

	}

}
