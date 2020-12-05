using System.Text;

namespace WindowAES.AES
{
    class Encryption : AesManager
    {


        public Encryption()
        {
            
        }

        private byte[][] InitialRound(byte[][] stateBlock, byte[][] cipherKey)
        {
            return AddRoundKey(stateBlock, cipherKey);
        }

        private byte[][] Round(byte[][] stateBlock, byte[][] cipherKey)
        {

            //1.subBytes
            stateBlock = SubBytes(stateBlock, Sbox);
            //2.ShiftRows
            stateBlock = ShiftRows(stateBlock);
            //3. MixColumn
            stateBlock = MixColumn(stateBlock);
            //4. AddRoundKey: state + ciphertext
            stateBlock = AddRoundKey(stateBlock, cipherKey);
            return stateBlock;
        }

        private byte[][] LastRound(byte[][] stateBlock, byte[][] cipherKey)
        {
            //1.subBytes
            stateBlock = SubBytes(stateBlock, Sbox);
            //2.ShiftRows
            stateBlock = ShiftRows(stateBlock);
            //3. AddRoundKey: state + ciphertext
            stateBlock = AddRoundKey(stateBlock, cipherKey);
            return stateBlock;
        }

        private byte[][] EncryptBlockProcess(byte[][] stateBlock)
        {
            //1. FIRST ROUND
            stateBlock = InitialRound(stateBlock,ExpandedKey[0]);

            for (var i = 1; i < NofRound ; i++)
            {
                //2. INTERNAL ROUND
                stateBlock = Round(stateBlock, ExpandedKey[i]);
            }
            //3. LAST ROUND

            stateBlock = LastRound(stateBlock, ExpandedKey[NofRound]);
            return stateBlock;
        }

        public string Encrypt(string plaintext, string key)
        {
            var output = new StringBuilder();
            var plainBytes = Encoding.Default.GetBytes(plaintext);
            var cipherkey = ConvertStringtoByteBox(key);
            ExpandKey(cipherkey);

            for (var i = 0; i < (plaintext.Length / KeySize)+1; i++)
            {
                var stateInput = SliceBoxByte(plainBytes, i * KeySize);
                var stateOutput = EncryptBlockProcess(stateInput);
                var result = ConvertByteBoxToString(stateOutput);
                output.Append(result);
            }

            return output.ToString();
        }

    }
}
