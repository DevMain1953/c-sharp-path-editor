using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace PathEditor
{
    /// <summary>
    /// This class enables users to work with memory of game process
    /// </summary>
    public class MemoryEditor
    {
        //External WIN API function that opens process and returns its handle
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(uint processAccess, bool bInheritHandle, int processId);

        //External WIN API function that closes process handle
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        //External WIN API function that reads data from process memory
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesRead);

        //External WIN API function that writes data to process memory
        [DllImport("kernel32.dll")]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, Int32 nSize, out IntPtr lpNumberOfBytesWritten);

        private int pID = 0; //Stores ID of process
        public float[,] pointsOfPath = new float[44, 3]; //Stores coordinates of all points in flight path
        public int matrixRowCount = 44; //Stores count of rows in matrix

        /// <summary>
        /// Gets process ID from list of running processes in system and saves it to property
        /// </summary>
        /// <param name="procName">Name of process to find</param>
        public void GetProcessID(string procName)
        {
            var pList = Process.GetProcesses();
            if (pList.Count() != 0)
            {
                foreach (var process in pList)
                {
                    if (process.ProcessName == procName)
                    {
                        this.pID = process.Id;
                        MessageBox.Show("Found game");
                        return;
                    }
                }
                MessageBox.Show("Game was not found");
            }
        }

        /// <summary>
        /// Creates text file and writes log information to it, log information is array of coordinates that was read from process
        /// </summary>
        /// <param name="fileName">Name of file that will be created</param>
        public void LogInfo(string fileName)
        {
            // Checks if file already exists. If yes, deletes it.     
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (StreamWriter sw = File.CreateText(fileName))
            {
                string text = "";
                for (int i = 0; i < this.matrixRowCount; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {
                        text = text + pointsOfPath[i, j].ToString() + " ";
                    }
                    text = text + '\n';
                }
                sw.Write(text);
                sw.Close();
            }
        }

        /// <summary>
        /// Reads coordinates of each point in flight path from game process then saves it to array
        /// </summary>
        /// <param name="baseAddress">Base address of memory to which offsets will be added to find target address</param>
        /// <param name="offsets">Array of offsets that will be added to base address</param>
        public void ReadCoordinates(int baseAddress, byte[] offsets)
        {
            if (this.pID != 0 && baseAddress != 0 && offsets.Length != 0)
            {
                byte[] buffer = new byte[4];
                IntPtr bytesread;
                var handle = OpenProcess(0x001F0FFF, false, this.pID);

                //Finding target address with pointers starts here
                ReadProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);
                for (var i = 0; i < offsets.Length; i++)
                {
                    baseAddress = BitConverter.ToInt32(buffer, 0); //Saves address to which previous address points
                    baseAddress = baseAddress + offsets[i]; //Adds offset to address
                    ReadProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);
                }
                //Ends here

                //Reading coordinates
                for (int i = 0; i < this.matrixRowCount; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        ReadProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);
                        pointsOfPath[i, j] = BitConverter.ToSingle(buffer, 0);
                        baseAddress = baseAddress + 0x4;
                    }
                    baseAddress = baseAddress + 0x8;
                }
                CloseHandle(handle);
            }
        }

        /// <summary>
        /// Gets coordinates from array and writes it to game process
        /// </summary>
        /// <param name="baseAddress">Base address of memory to which offsets will be added to find target address</param>
        /// <param name="offsets">Array of offsets that will be added to base address</param>
        public void WriteCoordinates(int baseAddress, byte[] offsets)
        {
            if (this.pID != 0 && baseAddress != 0 && offsets.Length != 0)
            {
                byte[] buffer = new byte[4];
                IntPtr bytesread;
                var handle = OpenProcess(0x001F0FFF, false, this.pID);

                //Finding target address with pointers starts here
                ReadProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);
                for (var i = 0; i < offsets.Length; i++)
                {
                    baseAddress = BitConverter.ToInt32(buffer, 0); //Saves address to which previous address points
                    baseAddress = baseAddress + offsets[i]; //Adds offset to address
                    ReadProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);
                }
                //Ends here

                //Writing coordinates
                for (int i = 0; i < this.matrixRowCount; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        buffer = BitConverter.GetBytes(pointsOfPath[i, j]);
                        WriteProcessMemory(handle, (IntPtr)baseAddress, buffer, 4, out bytesread);  
                        baseAddress = baseAddress + 0x4;
                    }
                    baseAddress = baseAddress + 0x8;
                }
                CloseHandle(handle);
            }
        }
    }
}
