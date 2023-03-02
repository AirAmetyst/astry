using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public  class Opponent : MonoBehaviour
    {
        private static GameObject _gameObject;
        public static GameObject GetGameObject()
        {
            return _gameObject;
        }
    }
}
