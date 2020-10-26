using System;

namespace Shop_Device.Device.Interface
{
    public interface IDevice
    {
        IDevice Clone();
        void GetInformationDevice();
    }
}
