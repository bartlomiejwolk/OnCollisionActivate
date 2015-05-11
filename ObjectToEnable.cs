﻿using UnityEngine;

namespace GameObjectActivator {

    /// Object to enable.
    [System.Serializable]
    // todo rename to ObjectSlot 
    public class ObjectToEnable {

        /// Game object.
        [SerializeField]
        private GameObject _objToEnable;
        public GameObject ObjToEnable {
            get { return _objToEnable; }
            set { _objToEnable = value; }
        }

        /// Select to include or exclude a given tag.
        [SerializeField]
        private TagOptions _tagOption;
        public TagOptions TagOption {
            get { return _tagOption; }
        }

        /// On collision with objects with this tag
        /// the object won't be enabled.
        [SerializeField]
        private string _tag;
        public string ExcludeTag {
            get { return _tag; }
            set { _tag = value; }
        }
    }

}