using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turgo.Lib
{
    public class Connection
    {
        public BluetoothClient Client { get; set; }
        public BluetoothDeviceInfo[] Peers { get; set; }
        public BluetoothDeviceInfo Device { get; set; }
        public BluetoothAddress Address { get; set; }

        public Connection()
        {
            Client = new BluetoothClient();
        }

        /// <summary>
        /// Discovers bluetooth devices around and set Peers property
        /// </summary>
        public void Discover()
        {
            Peers = Client.DiscoverDevices();
            Console.WriteLine("Searching devices...");
            int i = 0;
            foreach (BluetoothDeviceInfo device in Peers)
            {
                Console.WriteLine(++i + " - " + device.DeviceName + " (" + device.DeviceAddress + ") - RSSI : " + device.Rssi);
            }
            Console.WriteLine("****** End of list ******");
        }

        /// <summary>
        /// Uses for getting selected device
        /// </summary>
        /// <param name="index">Index number of selected device</param>
        /// <returns>Selected bluetooth device</returns>
        public BluetoothDeviceInfo getDevice(int index)
        {
            return Peers[index - 1];
        }

        /// <summary>
        /// Uses for getting selected device address info
        /// </summary>
        /// <returns>Address information of selected device</returns>
        public BluetoothAddress getDeviceAddress()
        {
            return Device.DeviceAddress;
        }
    }
}
