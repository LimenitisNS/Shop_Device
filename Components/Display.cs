using Shop_Device.Components.Interface;

namespace Shop_Device.Components
{
    class Display : IComponents
    {
        public enum Format
        {
            HD,
            FullHD,
            UltraHD
        }

        public Format format { get; set; }

        public Display(Format format)
        {
            this.format = format;
        }

        public override string ToString()
        {
            switch (this.format)
            {
                case Format.HD:
                    return "HD";

                case Format.FullHD:
                    return "FullHD";

                case Format.UltraHD:
                    return "UltraHD";

                default:
                    return "-";
            }
        }
    }
}
