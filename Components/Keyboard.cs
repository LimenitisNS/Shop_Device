﻿using Shop_Device.Components.Interface;

namespace Shop_Device.Components
{
    class Keyboard : IComponents
    {
        public enum Buttons
        {
            Buttons_101,
            Buttons_108
        }

        public Buttons buttons { get; set; }

        public Keyboard(Buttons buttons)
        {
            this.buttons = buttons;
        }

        public override string ToString()
        {
            switch (this.buttons)
            {
                case Buttons.Buttons_101:
                    return "101 buttons";

                case Buttons.Buttons_108:
                    return "108 buttons";

                default:
                    return "-";
            }
        }
    }
}
