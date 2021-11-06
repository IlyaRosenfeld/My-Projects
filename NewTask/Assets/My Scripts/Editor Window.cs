using UnityEngine;
using UnityEditor;

public class MyWindow : EditorWindow
{
    GameObject NewObject = null;
    public int xStep;
    public int yStep;
    public int zStep;  // Step
    static int xCopies;
    static int yCopies;
    static int zCopies; // Number of copies



    [MenuItem("My Tools/Array Tool")]

    public static void ShowWindow()
    {
        GetWindow<MyWindow>("Editor Window");
    }

      public void OnGUI()
       {
        GUILayout.Label("Label");

        xCopies = EditorGUILayout.IntField("Number of copies on X axis", xCopies);
        yCopies = EditorGUILayout.IntField("Number of copies on Y axis", yCopies);
        zCopies = EditorGUILayout.IntField("Number of copies on Z axis", zCopies);
        xStep = EditorGUILayout.IntField("X Step", xStep);
        yStep = EditorGUILayout.IntField("Y Step", yStep);
        zStep = EditorGUILayout.IntField("Z Step", zStep);


        if (GUILayout.Button("Apply"))
        {
            foreach (GameObject obj in Selection.gameObjects)
            {
                
                Debug.Log("Wow");
                for (int i = 0; i < xCopies; i++)
                { 
                  NewObject = Instantiate(obj, new Vector3(obj.transform.position.x + xStep + xStep*i, obj.transform.position.y, obj.transform.position.z), Quaternion.identity);
                }

                for (int i = 0; i < yCopies; i++)
                {
                    NewObject = Instantiate(obj, new Vector3(obj.transform.position.x, obj.transform.position.y + yStep + yStep*i, obj.transform.position.z), Quaternion.identity);
                }

                for (int i = 0; i < zCopies; i++)
                {
                    NewObject = Instantiate(obj, new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z + zStep + zStep * i), Quaternion.identity);
                }

               
            }
        }
        
       }
}

