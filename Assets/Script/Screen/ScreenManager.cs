using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZUNGAS.Core.Singleton;
using DG.Tweening;

namespace Screens 
{
    public class ScreenManager : Singleton<ScreenManager>
    {
        public List<ScreenBase> screenBases;

        public ScreenType startScreen = ScreenType.Panel;

        private ScreenBase _currentScreen;

        public Vector3 vec;

        private void Start()
        {
            HideAll();
            ShowByType(startScreen);
        }

        private void Scale(Transform t, float size = 1.2f)
        {
            t.localScale = Vector3.one * size;
        }

        public void ShowByType(ScreenType type)
        {
            if (_currentScreen != null) _currentScreen.Hide();

            var nextScreen = screenBases.Find(i => i.screenType == type);

            nextScreen.Show();
            _currentScreen = nextScreen;

        }

        public void HideAll()
        {
            screenBases.ForEach(i => i.Hide());
        }
    }
}