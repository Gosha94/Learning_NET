using System;
using System.Linq;

namespace IpMaskCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie
            /*
            
            Учитывая IP-адрес и маску в формате CIDR, вы должны вывести сетевой адрес и широковещательный адрес.

            IP-адрес - это адрес компьютера в сети. IP-адрес состоит из двух частей: сетевой и машинной. Мы можем разделить две части с помощью маски.
            
            Маска в двоичном формате представляет собой непрерывную часть единиц, сменяющуюся непрерывной частью нулей. Это не может быть смесь 1 и 0.
            
            Чтобы узнать сетевой адрес IP, мы действуем следующим образом:
            Для записи 192.168.0.15/24 IP-адрес машины - 192.168.0.15, а часть маски - 24.
            
            Часть маски означает, что первые 24 бита маски установлены на 1, а последние - на 0:
            Маска: 11111111.11111111.11111111.00000000
            В целых числах, что соответствует 255.255.255.0
            
            Чтобы узнать сетевой адрес, мы берем все биты с 1 в маске:
            192.168.0.15 в двоичном формате
            11000000.10101000.00000000.00001111
            11111111.11111111.11111111.00000000 -> это маска в двоичном формате
            Теперь сетевая часть IP-адреса:
            11000000.10101000.00000000
            После помещаем все 0, что нам нужно, чтобы получить в общей сложности 32 цифры
            Сетевой адрес теперь
            10000000.10101000.00000000.00000000
            В целых числах это означает
            192.168.0.0
            
            Широковещательный адрес - это сетевой адрес, в котором все биты в машинной части установлены на 1.
            
            Если мы возьмем тот же пример, мы получим это
            192.168.0.15 в двоичном формате
            11000000.10101000.00000000.00001111
            11111111.11111111.11111111.00000000 -> это маска в двоичном формате
            Широковещательный адрес:
            11000000.10101000.00000000.11111111 -> целое число, что означает 192.168.0.255
            
            Input:
            A ip address and a mask in CIDR format.

            Example:
            192.168.0.5/24
            ---
            Result:
            The network address and the broadcast address on two different lines.

            Example:
            192.168.0.0
            192.168.0.255
             */
            #endregion

            // 77.65.155.7/7

            // 76.0.0.0
            // 77.255.255.255

            string inputData = "77.65.155.7/7";
            var ipWithMask = inputData.Split('/');
                        
            var result = // GetIpInBinaryFormat()
                         // Order of performing: Split -> Foreach -> Convert.ToString -> ToArray -> String.Join
                ipWithMask[0]
                    .Split('.')
                        .Select(x => Convert.ToString(Int32.Parse(x), 2).PadLeft(8, '0'))  // PadLeft - добавляем слева числа нули, пока кол-во символов не будет достигать 8
                .ToArray()
            ;

            var mask = Int32.Parse(ipWithMask[1]);

            var numberOfRoundMaskOctets = (mask / 8);
            
            string[] broadcastAddr = new string[result.Length];
            result.CopyTo(broadcastAddr, 0);

            string finalNetworkAddr;
            string finalBroadcastAddr;

            if (mask % 8 != 0)
            {
                // CuttedMaskCalc();
                var numbOfOriginBitsInOctet = mask - (8 * numberOfRoundMaskOctets);
                
                for (int i = numberOfRoundMaskOctets; i <= result.Length - 1; i++)
                {
                    string tempData = "";
                    tempData = result[i].Substring(0, numbOfOriginBitsInOctet);

                    if (i == numberOfRoundMaskOctets) // Octet, going after rounded
                    {
                        result[i] = tempData.PadRight(8, '0');
                        broadcastAddr[i] = tempData.PadRight(8, '1');
                    }                    
                    else // Next Octets
                    {
                        result[i] = ("").PadLeft(8, '0');
                        broadcastAddr[i] = ("").PadLeft(8, '1');
                    }
                }
            }
            else
            {
                // RoundedMaskCalc();

                for (int i = numberOfRoundMaskOctets; i <= result.Length - 1; i++)
                {
                    result[i] = ("").PadLeft(8, '0');
                    broadcastAddr[i] = ("").PadLeft(8, '1');
                }                               
            }            

            finalNetworkAddr = // GetIpInDecimalFormat()
                    String.Join(".", 
                        (result.Select(x => Convert.ToString(Convert.ToInt32(x, 2))) ) 
                    );
            finalBroadcastAddr = // GetIpInDecimalFormat()
                String.Join(".", 
                    (broadcastAddr.Select(x => Convert.ToString(Convert.ToInt32(x, 2)) ) )
                );

            Console.WriteLine(finalNetworkAddr);
            Console.WriteLine(finalBroadcastAddr);
            Console.ReadLine();
        }
    }
}