using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UIElements;

public class MyCustomEditor : EditorWindow
{

    [MenuItem("Tools/My Custom Editor")]
    static void Init()
    {
        MyCustomEditor windw = GetWindow<MyCustomEditor>(typeof(Cube));
        windw.minSize = new Vector2(100, 100);
        windw.maxSize = new Vector2(500, 500);
        windw.Show();
    }

    private void OnGUI()
    {
        

    }
}
