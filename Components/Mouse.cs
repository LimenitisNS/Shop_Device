﻿using Shop_Device.Components.Interface;

namespace Shop_Device.Components
{
    class Mouse : IComponents
    {
        public enum Button
        {
            Button_2
        }

        public Button button { get; set; }

        public Mouse(Button button)
        {
            this.button = button;
        }

        public override string ToString()
        {
            switch (this.button)
            {
                case Button.Button_2:
                    return "2 button";

                default:
                    return "-";
            }
        }
    }
}
