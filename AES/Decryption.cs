using System.Text;

namespace WindowAES.AES
{
    class Decryption : AesManager
    {
        public Decryption()
        {
            
        }

        private byte[][] InitialRound(byte[][] stateBlock, byte[][] cipherKey)
        {
            //3. AddRoundKey: state + ciphertext
            stateBlock = AddRoundKey(stateBlock, cipherKey);
            //2. Inverse ShiftRows
            stateBlock = InvShiftRows(stateBlock);
            //1. Inverse subBytes
            stateBlock = SubBytes(stateBlock, InvSbox);

            return stateBlock;
        }

        private byte[][] Round(byte[][] stateBlock, byte[][] cipherKey)
        {
            //4. AddRoundKey: state + ciphertext
            stateBlock = AddRoundKey(stateBlock, cipherKey);
            //3. InverseMixColumn
            stateBlock = InverseMixColumn(stateBlock);
            //2. Inverse ShiftRows
            stateBlock = InvShiftRows(stateBlock);
            //1. Inverse subBytes
            stateBlock = SubBytes(stateBlock, InvSbox); 
            return stateBlock;
        }

        private byte[][] LastRound(byte[][] stateBlock, byte[][] cipherKey)
        {
            return AddRoundKey(stateBlock, cipherKey);
        }

        private byte[][] DecryptBlockProcess(byte[][] stateBlock)
        {

            //1. FIRST ROUND
            stateBlock = InitialRound(stateBlock, ExpandedKey[NofRound]);

            for (var i = NofRound - 1; i >0 ; i--)
            {
                //2. INTERNAL ROUND
                stateBlock = Round(stateBlock, ExpandedKey[i]);
            }
            //3. LAST ROUND

            stateBlock = LastRound(stateBlock, ExpandedKey[0]);

            return stateBlock;
        }

        public string Decrypt(string ciphertext, string key)
        {
            var output = new StringBuilder();
            var cipherBytes = Encoding.Default.GetBytes(ciphertext);
            var cipherkey = ConvertStringtoByteBox(key);
            ExpandKey(cipherkey);

            for (var i = 0; i < (ciphertext.Length / KeySize)+1; i++)
            {
                var stateInput = SliceBoxByte(cipherBytes, i * KeySize); 
                var stateOutput = DecryptBlockProcess(stateInput);
                var result = ConvertByteBoxToString(stateOutput);

                output.Append(result);
            }

            return output.ToString();
        }


    }
}
