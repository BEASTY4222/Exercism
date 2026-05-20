using System.Collections;
using System.Data.SqlTypes;

public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        int prefix = 0;
        byte[] payload = new byte[9];

        if(reading >= 0){
            // Unsinghed nums
            if (reading >= 0 && reading <= ushort.MaxValue)
            {
                payload = BitConverter.GetBytes((ushort)reading);
                prefix = 2;
            }
            else if (reading >= 0 && reading <= uint.MaxValue)
            {
                payload = BitConverter.GetBytes((uint)reading);
                prefix = 4;
            }
            else
            {
                payload = BitConverter.GetBytes((ulong)reading);
                prefix = 8;

            }
        }else{
            // Singhed nums
            if (reading >= short.MinValue && reading <= short.MaxValue)
            {
                payload = BitConverter.GetBytes((short)reading);
                prefix = 256 - 2;
            }
            else if (reading >= int.MinValue && reading <= int.MaxValue)
            {
                payload = BitConverter.GetBytes((int)reading);
                prefix = 256 - 4;
            }
            else
            {
                payload = BitConverter.GetBytes((long)reading);
                prefix = 256 - 8;

            }
        }
        
        LinkedList<byte> resultBytesList = new LinkedList<byte>(payload){};

        resultBytesList.AddFirst((byte)prefix);
        while(resultBytesList.Count < 9) resultBytesList.AddLast(0);

        

        return resultBytesList.ToArray();
    }

    public static long FromBuffer(byte[] buffer)
    {
        throw new NotImplementedException("Please implement the static TelemetryBuffer.FromBuffer() method");
    }
}
