using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareButton : MonoBehaviour
{
    private string shareMessage;

    public void ClickShareButton()
    {
        shareMessage = "Guys I play the best game in the world. Download now! Unlock Characters. Football Players Link:https://play.google.com/store/apps/details?id=com.NinjaGamer.FootballPlayers Youtube Channel Link:https://www.youtube.com/channel/UC59bmp6X7em663PSZ9xM5DA?view_as=subscriber Instagram Profile Link:https://www.instagram.com/ninjagamer.official/";

        StartCoroutine(TakeSSAndShare());
    }

    private IEnumerator TakeSSAndShare()
    {
        yield return new WaitForEndOfFrame();

        Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        ss.Apply();

        string filePath = Path.Combine(Application.temporaryCachePath, "shared img.png");
        File.WriteAllBytes(filePath, ss.EncodeToPNG());

        Destroy(ss);

        new NativeShare().AddFile(filePath).SetSubject("Football Players").SetText(shareMessage).Share();
    }
}
