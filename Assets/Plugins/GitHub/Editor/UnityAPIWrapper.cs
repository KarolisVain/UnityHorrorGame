using UnityEditor;
using UnityEngine;
using System.IO;
using System;

namespace GitHub.Unity
{
    [InitializeOnLoad]
    public class UnityAPIWrapper : ScriptableSingleton<UnityAPIWrapper>
    {
        static UnityAPIWrapper()
        {
#if UNITY_2018_2_OR_NEWER
            Editor.finishedDefaultHeaderGUI += editor => {
                UnityShim.Raise_Editor_finishedDefaultHeaderGUI(editor);
<<<<<<< HEAD
                //
=======
>>>>>>> 9b646d3e66a22c61318c775319ae4d0cd01c6a8a
            };
#endif
        }
    }
}