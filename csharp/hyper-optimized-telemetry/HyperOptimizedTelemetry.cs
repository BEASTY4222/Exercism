public static class TelemetryBuffer
{
    public static byte[] ToBuffer(long reading)
    {
        byte[] result = new byte[9];
        byte[] payload;
        byte prefix;

        if (reading >= 0)
        {
            if (reading <= ushort.MaxValue)
            {
                payload = BitConverter.GetBytes((ushort)reading);
                prefix = 2;
            }
            else if (reading <= int.MaxValue)
            {
                payload = BitConverter.GetBytes((int)reading);
                prefix = 252; // 256 - 4
            }
            else if (reading <= uint.MaxValue)
            {
                payload = BitConverter.GetBytes((uint)reading);
                prefix = 4;
            }
            else
            {
                payload = BitConverter.GetBytes(reading);
                prefix = 248; // 256 - 8
            }
        }
        else
        {
            if (reading >= short.MinValue)
            {
                payload = BitConverter.GetBytes((short)reading);
                prefix = 254; // 256 - 2
            }
            else if (reading >= int.MinValue)
            {
                payload = BitConverter.GetBytes((int)reading);
                prefix = 252; // 256 - 4
            }
            else
            {
                payload = BitConverter.GetBytes(reading);
                prefix = 248; // 256 - 8
            }
        }

        result[0] = prefix;
        Array.Copy(payload, 0, result, 1, payload.Length);

        return result;
    }

    public static long FromBuffer(byte[] buffer)
    {
        byte prefix = buffer[0];

        if (prefix == 2)
        {
            return BitConverter.ToUInt16(buffer, 1);
        }

        else if (prefix == 4)
        {
            return BitConverter.ToUInt32(buffer, 1);
        }

        else if (prefix == 254)
        {
            return BitConverter.ToInt16(buffer, 1);
        }

        else if (prefix == 252)
        {
            return BitConverter.ToInt32(buffer, 1);
        }
        else if(prefix != 2 && prefix != 4 && prefix != 254 && prefix != 252 && prefix != 8 && prefix != 248)
        {
            return 0;   
        }

        
        

        return BitConverter.ToInt64(buffer, 1);
    }
}
