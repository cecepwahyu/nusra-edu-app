using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game : MonoBehaviour
{
    public void exit() {
        Application.Quit();
    }

    public void back(string scene_name) {
        Application.LoadLevel(scene_name);
    }

    public void telegram() {
        Application.OpenURL("https://t.me/+7kWXwS_sEBI3M2U9");
    }

    public void video(string scene_name) {
        Application.LoadLevel(scene_name);
    }
}