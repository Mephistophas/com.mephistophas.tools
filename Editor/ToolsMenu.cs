using UnityEditor;
using UnityEngine;
using System;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;


namespace Mephistophas
{
    public static class ToolsMenu
    {
        
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Dir("_Project","Scripts","Art","Scenes","Sounds");
            SubDir("_Project","Art","Animations","Sprites");
            Refresh();
        }

        [MenuItem("Tools/Setup/Create Mephistophas Folders")]
        public static void CreateMephasFolders()
        {
            Dir("_Project","UIElements","Art","Scripts","Sounds");
            SubDir("_Project","Art","Animations","Sprites");
            SubDir("_Project","UIElements","UI","Style");
            Refresh();
        }

        [MenuItem("Tools/Setup/Create Elaborate Folders")]
        public static void CreateElaborateFolders()
        {
            Dir("_Project","UIElements","Art","Scripts","Sounds");
            SubDir("_Project","Art","Animations","Sprites");
            SubDir("_Project","UIElements","mainMenu","game","credits","_Style");
            Refresh();
        }

        public static void Dir(string root,params string[] dir)
        {
            var fullpath = Combine(dataPath,root);
            foreach (var newDirectory in dir)
            {
                CreateDirectory(Combine(fullpath, newDirectory));
            }
        }        
        
        public static void SubDir(string root,string dir,params string[] dirs)
        {
            var fullpath =  Combine(Combine(dataPath,root),dir);
            foreach (var newDirectory in dirs)
            {
                CreateDirectory(Combine(fullpath, newDirectory));
            }
        }
    }
}
