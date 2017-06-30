# QRGenUnity
Offline QR Code Generator for Unity


## Usage
```c#
public UnityEngine.UI.RawImage qrImageView;

void Start () {
  string inputText = "http://google.com";
  Texture2D texture = new Texture2D (256, 256);
  qrImageView.texture = texture;
  QRGen.Instance.create (inputText,(Texture2D)qrImageView.texture);
}
```

http://zxing.net/　　
