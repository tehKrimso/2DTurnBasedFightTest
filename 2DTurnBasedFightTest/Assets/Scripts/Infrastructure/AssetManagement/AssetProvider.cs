﻿using UnityEngine;

namespace Infrastructure.AssetManagement
{
    public class AssetProvider : IAssetProvider
    {
        public GameObject Instantiate(string path)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab);
        }

        public GameObject Instantiate(string path, Transform at)
        {
            var prefab = Resources.Load<GameObject>(path);
            return Object.Instantiate(prefab,at);
        }
    }
}