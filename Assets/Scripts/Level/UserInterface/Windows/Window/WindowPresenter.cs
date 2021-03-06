using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking.Level.UserInterface
{
    public class WindowPresenter : Presenter<WindowView, Model>
    {
        public ButtonPresenter Button { get; private set; }


        public WindowPresenter(WindowView view) : base(view)
        {
            Button = new ButtonPresenter(view.Button);
        }
    }
}