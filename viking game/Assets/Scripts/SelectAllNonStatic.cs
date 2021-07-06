using System;
using System.Collections.Generic;
using System.Linq;

using JetBrains.Annotations;

using UnityEditor;

using UnityEngine;
using UnityEngine.SceneManagement;

public static class SelectAllNonStatic
{
    [MenuItem("GameObject/Select All Non-Static", false, 300), UsedImplicitly]
    public static void SelectAllNonStaticGameObjects()
    {
        SelectAllThat(go => !go.isStatic);
    }

    [MenuItem("GameObject/Select All Static", false, 301), UsedImplicitly]
    public static void SelectAllStaticGameObjects()
    {
        SelectAllThat(go => go.isStatic);
    }

    private static void SelectAllThat([NotNull] Func<GameObject, bool> check)
    {
        if (check == null)
        {
            throw new ArgumentNullException("check");
        }

        Scene ActiveScene = SceneManager.GetActiveScene();

        GameObject[] RootGameObjects = ActiveScene.GetRootGameObjects();

        List<GameObject> AllGameObjects = new List<GameObject>(RootGameObjects);

        foreach (GameObject RootGameObject in RootGameObjects)
        {
            AddChildrenRecoursive(RootGameObject, AllGameObjects);
        }

        Selection.objects = AllGameObjects
            .Where(check)
            .Select(go => go as UnityEngine.Object)
            .ToArray();
    }

    private static void AddChildrenRecoursive([NotNull] GameObject target, [NotNull] ICollection<GameObject> collection)
    {
        if (target == null)
        {
            throw new ArgumentNullException("target");
        }

        if (collection == null)
        {
            throw new ArgumentNullException("collection");
        }

        for (int I = 0; I < target.transform.childCount; I++)
        {
            GameObject Child = target.transform.GetChild(I).gameObject;
            collection.Add(Child);

            AddChildrenRecoursive(Child, collection);
        }
    }
}