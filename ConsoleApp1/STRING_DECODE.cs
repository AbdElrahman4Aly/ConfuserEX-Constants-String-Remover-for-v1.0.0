using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class STRING_DECODE
    {
        internal static byte[] byte_0;
        internal static T smethod_2<T>(uint uint_0, uint left, uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            if ((ulong)num == 2UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 3UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 0UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }
        internal static T smethod_3<T>(uint uint_0,uint left,uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            if ((ulong)num == 2UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 0UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 3UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }
        internal static T smethod_4<T>(uint uint_0,uint left,uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            if ((ulong)num == 0UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 3UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 2UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }
        internal static T smethod_5<T>(uint uint_0,uint left,uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            if ((ulong)num == 0UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 3UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 1UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }
        internal static T smethod_6<T>(uint uint_0,uint left,uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            if ((ulong)num == 3UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 1UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 0UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }

        internal static T smethod_end<T>(uint uint_0, uint left, uint right)
        {
            uint_0 = (uint_0 * left ^ right);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            num = 3;
            if ((ulong)num == 3UL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 2UL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 0UL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }

        internal static T smethod_<T>(uint uint_0, uint param1, uint param2)
        {
            uint_0 = (uint_0 * param1 ^ param2);
            uint num = uint_0 >> 30;
            T result = default(T);
            uint_0 &= 1073741823u;
            uint_0 <<= 2;
            num = 3;
            if ((ulong)num == 3uL)
            {
                int count = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                result = (T)((object)string.Intern(Encoding.UTF8.GetString(byte_0, (int)uint_0, count)));
            }
            else if ((ulong)num == 2uL)
            {
                T[] array = new T[1];
                Buffer.BlockCopy(byte_0, (int)uint_0, array, 0, System.Runtime.InteropServices.Marshal.SizeOf(default(T)));
                result = array[0];
            }
            else if ((ulong)num == 0uL)
            {
                int num2 = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                int length = (int)byte_0[(int)((UIntPtr)(uint_0++))] | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 8 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 16 | (int)byte_0[(int)((UIntPtr)(uint_0++))] << 24;
                Array array2 = Array.CreateInstance(typeof(T).GetElementType(), length);
                Buffer.BlockCopy(byte_0, (int)uint_0, array2, 0, num2 - 4);
                result = (T)((object)array2);
            }
            return result;
        }


        internal static void smethod_1(uint num_, uint[] arrayy, uint num2_)
        {
            uint num = num_;
            uint[] array = arrayy;
            uint[] array2 = new uint[16];
            uint num2 = num2_;
            for (int i = 0; i < 16; i++)
            {
                num2 ^= num2 >> 12;
                num2 ^= num2 << 25;
                num2 ^= num2 >> 27;
                array2[i] = num2;
            }
            int num3 = 0;
            int num4 = 0;
            uint[] array3 = new uint[16];
            byte[] array4 = new byte[num * 4u];
            while ((long)num3 < (long)((ulong)num))
            {
                for (int j = 0; j < 16; j++)
                {
                    array3[j] = array[num3 + j];
                }
                array3[0] = (array3[0] ^ array2[0]);
                array3[1] = (array3[1] ^ array2[1]);
                array3[2] = (array3[2] ^ array2[2]);
                array3[3] = (array3[3] ^ array2[3]);
                array3[4] = (array3[4] ^ array2[4]);
                array3[5] = (array3[5] ^ array2[5]);
                array3[6] = (array3[6] ^ array2[6]);
                array3[7] = (array3[7] ^ array2[7]);
                array3[8] = (array3[8] ^ array2[8]);
                array3[9] = (array3[9] ^ array2[9]);
                array3[10] = (array3[10] ^ array2[10]);
                array3[11] = (array3[11] ^ array2[11]);
                array3[12] = (array3[12] ^ array2[12]);
                array3[13] = (array3[13] ^ array2[13]);
                array3[14] = (array3[14] ^ array2[14]);
                array3[15] = (array3[15] ^ array2[15]);
                for (int k = 0; k < 16; k++)
                {
                    uint num5 = array3[k];
                    array4[num4++] = (byte)num5;
                    array4[num4++] = (byte)(num5 >> 8);
                    array4[num4++] = (byte)(num5 >> 16);
                    array4[num4++] = (byte)(num5 >> 24);
                    array2[k] ^= num5;
                }
                num3 += 16;
            }

    byte_0 = smethod_0(array4);
        }
        internal static byte[] smethod_0(byte[] byte_1)
        {
            MemoryStream memoryStream = new MemoryStream(byte_1);

            Class1 @class = new Class1();
            byte[] buffer = new byte[5];
            memoryStream.Read(buffer, 0, 5);
            @class.method_5(buffer);
            long num = 0L;
            for (int i = 0; i < 8; i++)
            {
                int num2 = memoryStream.ReadByte();
                num |= (long)((long)((ulong)((byte)num2)) << 8 * i);
            }
            byte[] array = new byte[(int)num];
            MemoryStream stream_ = new MemoryStream(array, true);
            long long_ = memoryStream.Length - 13L;
            @class.method_4(memoryStream, stream_, long_, num);
            return array;
        }
        internal class Class1
    {
        // Token: 0x06000015 RID: 21 RVA: 0x000030A0 File Offset: 0x000012A0
        internal Class1()
        {
            this.uint_0 = uint.MaxValue;
            int num = 0;
            while ((long)num < 4L)
            {
                this.struct1_0[num] = new Struct1(6);
                num++;
            }
        }

        // Token: 0x06000016 RID: 22 RVA: 0x000031A0 File Offset: 0x000013A0
        internal void method_0(uint uint_3)
        {
            if (this.uint_0 != uint_3)
            {
                this.uint_0 = uint_3;
                this.uint_1 = Math.Max(this.uint_0, 1u);
                uint uint_4 = Math.Max(this.uint_1, 4096u);
                this.class4_0.method_0(uint_4);
            }
        }

        // Token: 0x06000017 RID: 23 RVA: 0x0000214A File Offset: 0x0000034A
        internal void method_1(int int_0, int int_1)
        {
            this.class3_0.method_0(int_0, int_1);
        }

        // Token: 0x06000018 RID: 24 RVA: 0x000031EC File Offset: 0x000013EC
        internal void method_2(int int_0)
        {
            uint num = 1u << int_0;
            this.class2_0.method_0(num);
            this.class2_1.method_0(num);
            this.uint_2 = num - 1u;
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00003224 File Offset: 0x00001424
        internal void method_3(Stream stream_0, Stream stream_1)
        {
            this.class0_0.method_0(stream_0);
            this.class4_0.method_1(stream_1, this.bool_0);
            for (uint num = 0u; num < 12u; num += 1u)
            {
                for (uint num2 = 0u; num2 <= this.uint_2; num2 += 1u)
                {
                    uint num3 = (num << 4) + num2;
                    this.struct0_0[(int)((UIntPtr)num3)].method_0();
                    this.struct0_1[(int)((UIntPtr)num3)].method_0();
                }
                this.struct0_2[(int)((UIntPtr)num)].method_0();
                this.struct0_3[(int)((UIntPtr)num)].method_0();
                this.struct0_4[(int)((UIntPtr)num)].method_0();
                this.struct0_5[(int)((UIntPtr)num)].method_0();
            }
            this.class3_0.method_1();
            for (uint num = 0u; num < 4u; num += 1u)
            {
                this.struct1_0[(int)((UIntPtr)num)].method_0();
            }
            for (uint num = 0u; num < 114u; num += 1u)
            {
                this.struct0_6[(int)((UIntPtr)num)].method_0();
            }
            this.class2_0.method_1();
            this.class2_1.method_1();
            this.struct1_1.method_0();
        }

        // Token: 0x0600001A RID: 26 RVA: 0x00003350 File Offset: 0x00001550
        internal void method_4(Stream stream_0, Stream stream_1, long long_0, long long_1)
        {
            this.method_3(stream_0, stream_1);

            Struct3 @struct = default(Struct3);
            @struct.method_0();
            uint num = 0u;
            uint num2 = 0u;
            uint num3 = 0u;
            uint num4 = 0u;
            ulong num5 = 0UL;
            if (0L < long_1)
            {
                this.struct0_0[(int)((UIntPtr)(@struct.uint_0 << 4))].method_1(this.class0_0);
                @struct.method_1();
                byte byte_ = this.class3_0.method_3(this.class0_0, 0u, 0);
                this.class4_0.method_5(byte_);
                num5 += 1UL;
            }
            while (num5 < (ulong)long_1)
            {
                uint num6 = (uint)num5 & this.uint_2;
                if (this.struct0_0[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0u)
                {
                    byte byte_2 = this.class4_0.method_6(0u);
                    byte byte_3;
                    if (!@struct.method_5())
                    {
                        byte_3 = this.class3_0.method_4(this.class0_0, (uint)num5, byte_2, this.class4_0.method_6(num));
                    }
                    else
                    {
                        byte_3 = this.class3_0.method_3(this.class0_0, (uint)num5, byte_2);
                    }
                    this.class4_0.method_5(byte_3);
                    @struct.method_1();
                    num5 += 1UL;
                }
                else
                {
                    uint num8;
                    if (this.struct0_2[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 1u)
                    {
                        if (this.struct0_3[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0u)
                        {
                            if (this.struct0_1[(int)((UIntPtr)((@struct.uint_0 << 4) + num6))].method_1(this.class0_0) == 0u)
                            {
                                @struct.method_4();
                                this.class4_0.method_5(this.class4_0.method_6(num));
                                num5 += 1UL;
                                continue;
                            }
                        }
                        else
                        {
                            uint num7;
                            if (this.struct0_4[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0u)
                            {
                                num7 = num2;
                            }
                            else
                            {
                                if (this.struct0_5[(int)((UIntPtr)@struct.uint_0)].method_1(this.class0_0) == 0u)
                                {
                                    num7 = num3;
                                }
                                else
                                {
                                    num7 = num4;
                                    num4 = num3;
                                }
                                num3 = num2;
                            }
                            num2 = num;
                            num = num7;
                        }
                        num8 = this.class2_1.method_2(this.class0_0, num6) + 2u;
                        @struct.method_3();
                    }
                    else
                    {
                        num4 = num3;
                        num3 = num2;
                        num2 = num;
                        num8 = 2u + this.class2_0.method_2(this.class0_0, num6);
                        @struct.method_2();
                        uint num9 = this.struct1_0[(int)((UIntPtr) Class1.smethod_0(num8))].method_1(this.class0_0);
                        if (num9 >= 4u)
                        {
                            int num10 = (int)((num9 >> 1) - 1u);
                            num = (2u | (num9 & 1u)) << num10;
                            if (num9 < 14u)
                            {
                                num += Struct1.smethod_0(this.struct0_6, num - num9 - 1u, this.class0_0, num10);
                            }
                            else
                            {
                                num += this.class0_0.method_3(num10 - 4) << 4;
                                num += this.struct1_1.method_2(this.class0_0);
                            }
                        }
                        else
                        {
                            num = num9;
                        }
                    }
                    if (((ulong)num >= num5 || num >= this.uint_1) && num == 4294967295u)
                    {
                        break;
                    }
                    this.class4_0.method_4(num, num8);
                    num5 += (ulong)num8;
                }
            }
            this.class4_0.method_3();
            this.class4_0.method_2();
            this.class0_0.method_1();
        }

        // Token: 0x0600001B RID: 27 RVA: 0x000036C4 File Offset: 0x000018C4
        internal void method_5(byte[] byte_0)
        {
            int int_ = (int)(byte_0[0] % 9);
            int num = (int)(byte_0[0] / 9);
            int int_2 = num % 5;
            int int_3 = num / 5;
            uint num2 = 0u;
            for (int i = 0; i < 4; i++)
            {
                num2 += (uint)((uint)byte_0[1 + i] << i * 8);
            }
            this.method_0(num2);
            this.method_1(int_2, int_);
            this.method_2(int_3);
        }

        // Token: 0x0600001C RID: 28 RVA: 0x00002159 File Offset: 0x00000359
        internal static uint smethod_0(uint uint_3)
        {
            uint_3 -= 2u;
            if (uint_3 < 4u)
            {
                return uint_3;
            }
            return 3u;
        }

        // Token: 0x04000009 RID: 9
        internal readonly Struct0[] struct0_0 = new Struct0[192];

        // Token: 0x0400000A RID: 10
        internal readonly Struct0[] struct0_1 = new Struct0[192];

        // Token: 0x0400000B RID: 11
        internal readonly Struct0[] struct0_2 = new Struct0[12];

        // Token: 0x0400000C RID: 12
        internal readonly Struct0[] struct0_3 = new Struct0[12];

        // Token: 0x0400000D RID: 13
        internal readonly Struct0[] struct0_4 = new Struct0[12];

        // Token: 0x0400000E RID: 14
        internal readonly Struct0[] struct0_5 = new Struct0[12];

        // Token: 0x0400000F RID: 15
        internal readonly Class1.Class2 class2_0 = new Class1.Class2();

        // Token: 0x04000010 RID: 16
        internal readonly Class1.Class3 class3_0 = new Class1.Class3();

        // Token: 0x04000011 RID: 17
        internal readonly Class4 class4_0 = new Class4();

        // Token: 0x04000012 RID: 18
        internal readonly Struct0[] struct0_6 = new Struct0[114];

        // Token: 0x04000013 RID: 19
        internal readonly Struct1[] struct1_0 = new Struct1[4];

        // Token: 0x04000014 RID: 20
        internal readonly Class0 class0_0 = new Class0();

        // Token: 0x04000015 RID: 21
        internal readonly Class1.Class2 class2_1 = new Class1.Class2();

        // Token: 0x04000016 RID: 22
        internal bool bool_0;

        // Token: 0x04000017 RID: 23
        internal uint uint_0;

        // Token: 0x04000018 RID: 24
        internal uint uint_1;

        // Token: 0x04000019 RID: 25
        internal Struct1 struct1_1 = new Struct1(4);

        // Token: 0x0400001A RID: 26
        internal uint uint_2;

        // Token: 0x02000006 RID: 6
        internal class Class2
        {
            // Token: 0x0600001D RID: 29 RVA: 0x00003724 File Offset: 0x00001924
            internal void method_0(uint uint_1)
            {
                for (uint num = this.uint_0; num < uint_1; num += 1u)
                {
                    this.struct1_0[(int)((UIntPtr)num)] = new Struct1(3);
                    this.struct1_1[(int)((UIntPtr)num)] = new Struct1(3);
                }
                this.uint_0 = uint_1;
            }

            // Token: 0x0600001E RID: 30 RVA: 0x0000377C File Offset: 0x0000197C
            internal void method_1()
            {
                this.struct0_0.method_0();
                for (uint num = 0u; num < this.uint_0; num += 1u)
                {
                    this.struct1_0[(int)((UIntPtr)num)].method_0();
                    this.struct1_1[(int)((UIntPtr)num)].method_0();
                }
                this.struct0_1.method_0();
                this.struct1_2.method_0();
            }

            // Token: 0x0600001F RID: 31 RVA: 0x000037E0 File Offset: 0x000019E0
            internal uint method_2(Class0 class0_0, uint uint_1)
            {
                if (this.struct0_0.method_1(class0_0) == 0u)
                {
                    return this.struct1_0[(int)((UIntPtr)uint_1)].method_1(class0_0);
                }
                uint num = 8u;
                if (this.struct0_1.method_1(class0_0) == 0u)
                {
                    num += this.struct1_1[(int)((UIntPtr)uint_1)].method_1(class0_0);
                }
                else
                {
                    num += 8u;
                    num += this.struct1_2.method_1(class0_0);
                }
                return num;
            }

            // Token: 0x06000020 RID: 32 RVA: 0x0000384C File Offset: 0x00001A4C
            internal Class2()
            {
            }

            // Token: 0x0400001B RID: 27
            internal readonly Struct1[] struct1_0 = new Struct1[16];

            // Token: 0x0400001C RID: 28
            internal readonly Struct1[] struct1_1 = new Struct1[16];

            // Token: 0x0400001D RID: 29
            internal Struct0 struct0_0 = default(Struct0);

            // Token: 0x0400001E RID: 30
            internal Struct0 struct0_1 = default(Struct0);

            // Token: 0x0400001F RID: 31
            internal Struct1 struct1_2 = new Struct1(8);

            // Token: 0x04000020 RID: 32
            internal uint uint_0;
        }

        // Token: 0x02000007 RID: 7
        internal class Class3
        {
            // Token: 0x06000021 RID: 33 RVA: 0x000038A0 File Offset: 0x00001AA0
            internal void method_0(int int_2, int int_3)
            {
                if (this.struct2_0 != null && this.int_1 == int_3 && this.int_0 == int_2)
                {
                    return;
                }
                this.int_0 = int_2;
                this.uint_0 = (1u << int_2) - 1u;
                this.int_1 = int_3;
                uint num = 1u << this.int_1 + this.int_0;
                this.struct2_0 = new Class1.Class3.Struct2[num];
                for (uint num2 = 0u; num2 < num; num2 += 1u)
                {
                    this.struct2_0[(int)((UIntPtr)num2)].method_0();
                }
            }

            // Token: 0x06000022 RID: 34 RVA: 0x00003924 File Offset: 0x00001B24
            internal void method_1()
            {
                uint num = 1u << this.int_1 + this.int_0;
                for (uint num2 = 0u; num2 < num; num2 += 1u)
                {
                    this.struct2_0[(int)((UIntPtr)num2)].method_1();
                }
            }

            // Token: 0x06000023 RID: 35 RVA: 0x00002167 File Offset: 0x00000367
            internal uint method_2(uint uint_1, byte byte_0)
            {
                return ((uint_1 & this.uint_0) << this.int_1) + (uint)(byte_0 >> 8 - this.int_1);
            }

            // Token: 0x06000024 RID: 36 RVA: 0x00002189 File Offset: 0x00000389
            internal byte method_3(Class0 class0_0, uint uint_1, byte byte_0)
            {
                return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_2(class0_0);
            }

            // Token: 0x06000025 RID: 37 RVA: 0x000021A5 File Offset: 0x000003A5
            internal byte method_4(Class0 class0_0, uint uint_1, byte byte_0, byte byte_1)
            {
                return this.struct2_0[(int)((UIntPtr)this.method_2(uint_1, byte_0))].method_3(class0_0, byte_1);
            }

            // Token: 0x06000026 RID: 38 RVA: 0x00002142 File Offset: 0x00000342
            internal Class3()
            {
            }

            // Token: 0x04000021 RID: 33
            internal Class1.Class3.Struct2[] struct2_0;

            // Token: 0x04000022 RID: 34
            internal int int_0;

            // Token: 0x04000023 RID: 35
            internal int int_1;

            // Token: 0x04000024 RID: 36
            internal uint uint_0;

            // Token: 0x02000008 RID: 8
            internal struct Struct2
            {
                // Token: 0x06000027 RID: 39 RVA: 0x000021C3 File Offset: 0x000003C3
                internal void method_0()
                {
                    this.struct0_0 = new Struct0[768];
                }

                // Token: 0x06000028 RID: 40 RVA: 0x00003964 File Offset: 0x00001B64
                internal void method_1()
                {
                    for (int i = 0; i < 768; i++)
                    {
                        this.struct0_0[i].method_0();
                    }
                }

                // Token: 0x06000029 RID: 41 RVA: 0x00003994 File Offset: 0x00001B94
                internal byte method_2(Class0 class0_0)
                {
                    uint num = 1u;
                    do
                    {
                        num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
                    }
                    while (num < 256u);
                    return (byte)num;
                }

                // Token: 0x0600002A RID: 42 RVA: 0x000039C8 File Offset: 0x00001BC8
                internal byte method_3(Class0 class0_0, byte byte_0)
                {
                    uint num = 1u;
                    for (; ; )
                    {
                        uint num2 = (uint)(byte_0 >> 7 & 1);
                        byte_0 = (byte)(byte_0 << 1);
                        uint num3 = this.struct0_0[(int)((UIntPtr)((1u + num2 << 8) + num))].method_1(class0_0);
                        num = (num << 1 | num3);
                        if (num2 != num3)
                        {
                            break;
                        }
                        if (num >= 256u)
                        {
                            goto IL_5E;
                        }
                    }
                    while (num < 256u)
                    {
                        num = (num << 1 | this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0));
                    }
                IL_5E:
                    return (byte)num;
                }

                // Token: 0x04000025 RID: 37
                internal Struct0[] struct0_0;
            }
        }
    }
        internal struct Struct0
        {
            // Token: 0x06000009 RID: 9 RVA: 0x000020D7 File Offset: 0x000002D7
            internal void method_0()
            {
                this.uint_0 = 1024u;
            }

            // Token: 0x0600000A RID: 10 RVA: 0x00002DEC File Offset: 0x00000FEC
            internal uint method_1(Class0 class0_0)
            {
                uint num = (class0_0.uint_1 >> 11) * this.uint_0;
                if (class0_0.uint_0 < num)
                {
                    class0_0.uint_1 = num;
                    this.uint_0 += 2048u - this.uint_0 >> 5;
                    if (class0_0.uint_1 < 16777216u)
                    {
                        class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
                        class0_0.uint_1 <<= 8;
                    }
                    return 0u;
                }
                class0_0.uint_1 -= num;
                class0_0.uint_0 -= num;
                this.uint_0 -= this.uint_0 >> 5;
                if (class0_0.uint_1 < 16777216u)
                {
                    class0_0.uint_0 = (class0_0.uint_0 << 8 | (uint)((byte)class0_0.stream_0.ReadByte()));
                    class0_0.uint_1 <<= 8;
                }
                return 1u;
            }

            // Token: 0x04000003 RID: 3
            internal uint uint_0;
        }
        internal class Class0
        {
            // Token: 0x06000010 RID: 16 RVA: 0x00002FE0 File Offset: 0x000011E0
            internal void method_0(Stream stream_1)
            {
                this.stream_0 = stream_1;
                this.uint_0 = 0u;
                this.uint_1 = uint.MaxValue;
                for (int i = 0; i < 5; i++)
                {
                    this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
                }
            }

            // Token: 0x06000011 RID: 17 RVA: 0x000020FE File Offset: 0x000002FE
            internal void method_1()
            {
                this.stream_0 = null;
            }

            // Token: 0x06000012 RID: 18 RVA: 0x00002107 File Offset: 0x00000307
            internal void method_2()
            {
                while (this.uint_1 < 16777216u)
                {
                    this.uint_0 = (this.uint_0 << 8 | (uint)((byte)this.stream_0.ReadByte()));
                    this.uint_1 <<= 8;
                }
            }

            // Token: 0x06000013 RID: 19 RVA: 0x0000302C File Offset: 0x0000122C
            internal uint method_3(int int_0)
            {
                uint num = this.uint_1;
                uint num2 = this.uint_0;
                uint num3 = 0u;
                for (int i = int_0; i > 0; i--)
                {
                    num >>= 1;
                    uint num4 = num2 - num >> 31;
                    num2 -= (num & num4 - 1u);
                    num3 = (num3 << 1 | 1u - num4);
                    if (num < 16777216u)
                    {
                        num2 = (num2 << 8 | (uint)((byte)this.stream_0.ReadByte()));
                        num <<= 8;
                    }
                }
                this.uint_1 = num;
                this.uint_0 = num2;
                return num3;
            }

            // Token: 0x06000014 RID: 20 RVA: 0x00002142 File Offset: 0x00000342
            internal Class0()
            {
            }

            // Token: 0x04000006 RID: 6
            internal uint uint_0;

            // Token: 0x04000007 RID: 7
            internal uint uint_1;

            // Token: 0x04000008 RID: 8
            internal Stream stream_0;
        }
        internal struct Struct1
        {
            // Token: 0x0600000B RID: 11 RVA: 0x000020E4 File Offset: 0x000002E4
            internal Struct1(int int_1)
            {
                this.int_0 = int_1;
                this.struct0_0 = new Struct0[1 << int_1];
            }

            // Token: 0x0600000C RID: 12 RVA: 0x00002ED8 File Offset: 0x000010D8
            internal void method_0()
            {
                uint num = 1u;
                while ((ulong)num < (ulong)(1L << (this.int_0 & 31)))
                {
                    this.struct0_0[(int)((UIntPtr)num)].method_0();
                    num += 1u;
                }
            }

            // Token: 0x0600000D RID: 13 RVA: 0x00002F10 File Offset: 0x00001110
            internal uint method_1(Class0 class0_0)
            {
                uint num = 1u;
                for (int i = this.int_0; i > 0; i--)
                {
                    num = (num << 1) + this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
                }
                return num - (1u << this.int_0);
            }

            // Token: 0x0600000E RID: 14 RVA: 0x00002F58 File Offset: 0x00001158
            internal uint method_2(Class0 class0_0)
            {
                uint num = 1u;
                uint num2 = 0u;
                for (int i = 0; i < this.int_0; i++)
                {
                    uint num3 = this.struct0_0[(int)((UIntPtr)num)].method_1(class0_0);
                    num <<= 1;
                    num += num3;
                    num2 |= num3 << i;
                }
                return num2;
            }

            // Token: 0x0600000F RID: 15 RVA: 0x00002FA0 File Offset: 0x000011A0
            internal static uint smethod_0(Struct0[] struct0_1, uint uint_0, Class0 class0_0, int int_1)
            {
                uint num = 1u;
                uint num2 = 0u;
                for (int i = 0; i < int_1; i++)
                {
                    uint num3 = struct0_1[(int)((UIntPtr)(uint_0 + num))].method_1(class0_0);
                    num <<= 1;
                    num += num3;
                    num2 |= num3 << i;
                }
                return num2;
            }

            // Token: 0x04000004 RID: 4
            internal readonly Struct0[] struct0_0;

            // Token: 0x04000005 RID: 5
            internal readonly int int_0;
        }
        internal struct Struct3
        {
            // Token: 0x06000033 RID: 51 RVA: 0x00002253 File Offset: 0x00000453
            internal void method_0()
            {
                this.uint_0 = 0u;
            }

            // Token: 0x06000034 RID: 52 RVA: 0x0000225C File Offset: 0x0000045C
            internal void method_1()
            {
                if (this.uint_0 < 4u)
                {
                    this.uint_0 = 0u;
                    return;
                }
                if (this.uint_0 < 10u)
                {
                    this.uint_0 -= 3u;
                    return;
                }
                this.uint_0 -= 6u;
            }

            // Token: 0x06000035 RID: 53 RVA: 0x00002296 File Offset: 0x00000496
            internal void method_2()
            {
                this.uint_0 = ((this.uint_0 < 7u) ? 7u : 10u);
            }

            // Token: 0x06000036 RID: 54 RVA: 0x000022AC File Offset: 0x000004AC
            internal void method_3()
            {
                this.uint_0 = ((this.uint_0 < 7u) ? 8u : 11u);
            }

            // Token: 0x06000037 RID: 55 RVA: 0x000022C2 File Offset: 0x000004C2
            internal void method_4()
            {
                this.uint_0 = ((this.uint_0 < 7u) ? 9u : 11u);
            }

            // Token: 0x06000038 RID: 56 RVA: 0x000022D9 File Offset: 0x000004D9
            internal bool method_5()
            {
                return this.uint_0 < 7u;
            }

            // Token: 0x0400002B RID: 43
            internal uint uint_0;
        }
        internal class Class4
        {
            // Token: 0x0600002B RID: 43 RVA: 0x000021D5 File Offset: 0x000003D5
            internal void method_0(uint uint_3)
            {
                if (this.uint_2 != uint_3)
                {
                    this.byte_0 = new byte[uint_3];
                }
                this.uint_2 = uint_3;
                this.uint_0 = 0u;
                this.uint_1 = 0u;
            }

            // Token: 0x0600002C RID: 44 RVA: 0x00002202 File Offset: 0x00000402
            internal void method_1(Stream stream_1, bool bool_0)
            {
                this.method_2();
                this.stream_0 = stream_1;
                if (!bool_0)
                {
                    this.uint_1 = 0u;
                    this.uint_0 = 0u;
                }
            }

            // Token: 0x0600002D RID: 45 RVA: 0x00002222 File Offset: 0x00000422
            internal void method_2()
            {
                this.method_3();
                this.stream_0 = null;
                Buffer.BlockCopy(new byte[this.byte_0.Length], 0, this.byte_0, 0, this.byte_0.Length);
            }

            // Token: 0x0600002E RID: 46 RVA: 0x00003A38 File Offset: 0x00001C38
            internal void method_3()
            {
                uint num = this.uint_0 - this.uint_1;
                if (num == 0u)
                {
                    return;
                }
                this.stream_0.Write(this.byte_0, (int)this.uint_1, (int)num);
                if (this.uint_0 >= this.uint_2)
                {
                    this.uint_0 = 0u;
                }
                this.uint_1 = this.uint_0;
            }

            // Token: 0x0600002F RID: 47 RVA: 0x00003A90 File Offset: 0x00001C90
            internal void method_4(uint uint_3, uint uint_4)
            {
                uint num = this.uint_0 - uint_3 - 1u;
                if (num >= this.uint_2)
                {
                    num += this.uint_2;
                }
                while (uint_4 > 0u)
                {
                    if (num >= this.uint_2)
                    {
                        num = 0u;
                    }
                    this.byte_0[(int)((UIntPtr)(this.uint_0++))] = this.byte_0[(int)((UIntPtr)(num++))];
                    if (this.uint_0 >= this.uint_2)
                    {
                        this.method_3();
                    }
                    uint_4 -= 1u;
                }
            }

            // Token: 0x06000030 RID: 48 RVA: 0x00003B0C File Offset: 0x00001D0C
            internal void method_5(byte byte_1)
            {
                this.byte_0[(int)((UIntPtr)(this.uint_0++))] = byte_1;
                if (this.uint_0 >= this.uint_2)
                {
                    this.method_3();
                }
            }

            // Token: 0x06000031 RID: 49 RVA: 0x00003B48 File Offset: 0x00001D48
            internal byte method_6(uint uint_3)
            {
                uint num = this.uint_0 - uint_3 - 1u;
                if (num >= this.uint_2)
                {
                    num += this.uint_2;
                }
                return this.byte_0[(int)((UIntPtr)num)];
            }

            // Token: 0x06000032 RID: 50 RVA: 0x00002142 File Offset: 0x00000342
            internal Class4()
            {
            }

            // Token: 0x04000026 RID: 38
            internal byte[] byte_0;

            // Token: 0x04000027 RID: 39
            internal uint uint_0;

            // Token: 0x04000028 RID: 40
            internal Stream stream_0;

            // Token: 0x04000029 RID: 41
            internal uint uint_1;

            // Token: 0x0400002A RID: 42
            internal uint uint_2;
        }



    }
}
