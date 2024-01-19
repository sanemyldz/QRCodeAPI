using BLL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class QRService : IQRService
    {
        public string GenerateQRCodeAsync()
        {
            byte[] numbers = new byte[8]; // 8 bytes for a 64-bit long integer

            using (RandomNumberGenerator random = RandomNumberGenerator.Create())
            {
                random.GetBytes(numbers);
            }

            // Convert bytes to a long integer and ensure it's positive
            long randomNumber = Math.Abs(BitConverter.ToInt64(numbers, 0));

            // Ensure the number is within the desired range
            long minValue = 1000000000L;
            long maxValue = 9999999999L;
            randomNumber = minValue + (randomNumber % (maxValue - minValue + 1));

            return randomNumber.ToString();
        }
    }

}
