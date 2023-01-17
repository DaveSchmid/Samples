//
// Copyright (c) .NET Foundation and Contributors
// See LICENSE file in the project root for full license information.
//

using System;
using System.Diagnostics;
using System.Threading;

namespace ManagedResources
{
    public class Program
    {
        public static void Main()
        {
            // to use managed resources:
            // 1. add a reference to nanoFramework.Runtime.Native
            // 2. Add a managed resource file (.resx extension)
            // 3. Access the resource using the appropriate getter as shown bellow



            //Thread.Sleep(2000);


            Debug.WriteLine($"File-10k has {Resources.GetBytes(Resources.BinaryResources.file_10k).Length} bytes");

            Debug.WriteLine($"File-20k has {Resources.GetBytes(Resources.BinaryResources.file_20k).Length} bytes");

            Debug.WriteLine($"File-30k has {Resources.GetBytes(Resources.BinaryResources.file_30k).Length} bytes");

            Debug.WriteLine($"File-40k has {Resources.GetBytes(Resources.BinaryResources.file_40k).Length} bytes");

            Debug.WriteLine($"File-50k has {Resources.GetBytes(Resources.BinaryResources.file_50k).Length} bytes");

            Debug.WriteLine($"File-60k has {Resources.GetBytes(Resources.BinaryResources.file_60k).Length} bytes");

            Debug.WriteLine($"File-70k has {Resources.GetBytes(Resources.BinaryResources.file_70k).Length} bytes");

            Debug.WriteLine($"File-80k has {Resources.GetBytes(Resources.BinaryResources.file_80k).Length} bytes");

            Debug.WriteLine($"File-90k has {Resources.GetBytes(Resources.BinaryResources.file_90k).Length} bytes");

            var pix = Resources.GetBytes(Resources.BinaryResources.pix);
            var lastValue = pix.GetValue(pix.Length - 1);
            int number = int.Parse(lastValue.ToString());
            string hex = number.ToString("x");
            Debug.WriteLine($"pix.png has {(pix).Length} bytes and last byte hex value is {hex}");

            Thread.Sleep(Timeout.Infinite);
        }
    }
}
