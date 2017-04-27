using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureBoxDemo
{
    class AppSettings
    {
        public bool EnableAutoSlideshow { get; set; }
        public int TimerInterval { get; set; }

        private static AppSettings instance = null;
        public delegate void ListenerAction();

        private List<ListenerAction> listeners = new List<ListenerAction>();

        private AppSettings()
        {
            // Let's set the default values for these properties
            EnableAutoSlideshow = false;
            TimerInterval = 2000;
        }

        public static AppSettings Instance { 
            get {
                if (instance == null) {
                    instance = new AppSettings();
                }

                return instance;
            }
        }

        public void AddListener(ListenerAction listener)
        {
            listeners.Add(listener);
        }

        public void NotifyListeners()
        {
            listeners.ForEach(listener => {
                listener();
            });
        }

    }
}
