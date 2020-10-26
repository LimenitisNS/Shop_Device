using Shop_Device.Components.Interface;

namespace Shop_Device.Components
{
    class TouchPad : IComponents
    {
        public enum Button
        {
            Button_1,
            Buttons_2
        }

        public Button button { get; set; }

        public TouchPad(Button button)
        {
            this.button = button;
        }

        public override string ToString()
        {
            switch (this.button)
            {
                case Button.Button_1:
                    return "1 button";

                case Button.Buttons_2:
                    return "2 buttons";

                default:
                    return "-";
            }
        }
    }
}
