using ZXing;
using ZXing.QrCode;
using UnityEngine;

public class QRGen : MonoBehaviour {

	private static QRGen _instance;

	public static QRGen Instance {
		get { 
			if (_instance == null) {
				_instance = new QRGen ();
			}
			return _instance;
		}
	}

	public void create(string inputString,Texture2D texture){
		var qrCodeColors = Write (inputString, texture.width, texture.height);
		texture.SetPixels32 (qrCodeColors);
		texture.Apply ();
	}

	private Color32[] Write(string content,int width,int height){
		var writer = new BarcodeWriter {
			Format = BarcodeFormat.QR_CODE,
			Options = new QrCodeEncodingOptions {
				Height = height,
				Width = width
			}
		};
		return writer.Write (content);
	}

}
