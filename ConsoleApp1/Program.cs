using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.Writer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static ModuleDefMD module;
        public static string Array_Name;
        public static uint[] arrayy;
        public static uint num;
        public static uint num2;

        public static uint smethod_2_Left_num;
        public static uint smethod_2_Right_num;

        public static uint smethod_3_Left_num;
        public static uint smethod_3_Right_num;

        public static uint smethod_4_Left_num;
        public static uint smethod_4_Right_num;

        public static uint smethod_5_Left_num;
        public static uint smethod_5_Right_num;

        public static uint smethod_6_Left_num;
        public static uint smethod_6_Right_num;

        
        static void Main(string[] args)
        {
            int LINE = 0;
            string STR = @"Strings Decrypted : ";
            Console.Title = "ConfuserEX Constants [ String Remover ] [+] Abdelrahman Mahrous";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"ConfuserEX Constants [ String Remover ]");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@" ");
            Console.WriteLine(@"This Tool for Original Version [ 1.0.0 ]");
            Console.WriteLine(@" ");
            Console.WriteLine(@"You Must Use de4dot Tool Befor Use This Tool !!!!!!!!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" ");
            Console.WriteLine(@" ");
            Console.WriteLine(@"[+] Code By Abdelrahman Mahrous ( AMUN TECH )");
            Console.WriteLine(@"[+]Telegram : t.me/AMUN_TECH");
            Console.WriteLine(@" ");
            Thread.Sleep(1500);
            module = ModuleDefMD.Load(args[0]);
            getArrayName(module);
            getArray(module, Array_Name);
            unit_num(module);
            unit_num2(module);
            STRING_DECODE.smethod_1(num, arrayy, num2);
            foreach (TypeDef type in module.Types)
            {
                if(type.FullName== "<Module>")
                {
                    foreach (MethodDef method in type.Methods)
                    {
                        if (!method.HasBody) continue;
                        if (method.FullName == "T <Module>::smethod_2<T>(System.UInt32)")
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i+1].OpCode == OpCodes.Mul && method.Body.Instructions[i + 2].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 3].OpCode == OpCodes.Xor)
                                {
                                    smethod_2_Left_num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    smethod_2_Right_num = (uint)method.Body.Instructions[i+2].GetLdcI4Value();
                                }
                            }
                            
                        }

                        if (method.FullName == "T <Module>::smethod_3<T>(System.UInt32)")
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].OpCode == OpCodes.Mul && method.Body.Instructions[i + 2].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 3].OpCode == OpCodes.Xor)
                                {
                                    smethod_3_Left_num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    smethod_3_Right_num = (uint)method.Body.Instructions[i + 2].GetLdcI4Value();
                                }
                            }
                        }

                        if (method.FullName == "T <Module>::smethod_4<T>(System.UInt32)")
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].OpCode == OpCodes.Mul && method.Body.Instructions[i + 2].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 3].OpCode == OpCodes.Xor)
                                {
                                    smethod_4_Left_num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    smethod_4_Right_num = (uint)method.Body.Instructions[i + 2].GetLdcI4Value();
                                }
                            }
                        }

                        if (method.FullName == "T <Module>::smethod_5<T>(System.UInt32)")
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].OpCode == OpCodes.Mul && method.Body.Instructions[i + 2].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 3].OpCode == OpCodes.Xor)
                                {
                                    smethod_5_Left_num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    smethod_5_Right_num = (uint)method.Body.Instructions[i + 2].GetLdcI4Value();
                                }
                            }
                        }

                        if (method.FullName == "T <Module>::smethod_6<T>(System.UInt32)")
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].OpCode == OpCodes.Mul && method.Body.Instructions[i + 2].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 3].OpCode == OpCodes.Xor)
                                {
                                    smethod_6_Left_num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    smethod_6_Right_num = (uint)method.Body.Instructions[i + 2].GetLdcI4Value();
                                }
                            }
                        }
                    }
                }
                
            }

            foreach (TypeDef type in module.Types)
            {
                    foreach (MethodDef method in type.Methods)
                    {
                        try
                        {
                            for (int i = 0; i < method.Body.Instructions.Count; i++)
                            {
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].Operand.ToString() == "System.String <Module>::smethod_2<System.String>(System.UInt32)")
                            {
                                try
                                {
                                    uint end = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    string DecryptString = STRING_DECODE.smethod_<string>(end, smethod_2_Left_num, smethod_2_Right_num);
                                    method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                                    method.Body.Instructions[i].Operand = DecryptString;
                                    method.Body.Instructions[i + 1].OpCode = OpCodes.Nop;
                                    LINE++;
                                }
                                catch (Exception ex) { }
                                
                            }
                            /////////////////////////
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].Operand.ToString() == "System.String <Module>::smethod_3<System.String>(System.UInt32)")
                            {
                                try
                                {
                                    uint end = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    string DecryptString = STRING_DECODE.smethod_<string>(end, smethod_3_Left_num, smethod_3_Right_num);
                                    method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                                    method.Body.Instructions[i].Operand = DecryptString;
                                    method.Body.Instructions[i + 1].OpCode = OpCodes.Nop;
                                    LINE++;
                                }
                                catch (Exception ex) { }
                            }
                            /////////////////////////////////
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].Operand.ToString() == "System.String <Module>::smethod_4<System.String>(System.UInt32)")
                            {
                                try
                                {
                                    uint end = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    string DecryptString = STRING_DECODE.smethod_<string>(end, smethod_4_Left_num, smethod_4_Right_num);
                                    method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                                    method.Body.Instructions[i].Operand = DecryptString;
                                    method.Body.Instructions[i + 1].OpCode = OpCodes.Nop;
                                    LINE++;
                                }
                                catch (Exception ex) { }
                            }
                            /////////////////////////////////
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].Operand.ToString() == "System.String <Module>::smethod_5<System.String>(System.UInt32)")
                            {
                                try
                                {
                                    uint end = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    string DecryptString = STRING_DECODE.smethod_<string>(end, smethod_5_Left_num, smethod_5_Right_num);
                                    method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                                    method.Body.Instructions[i].Operand = DecryptString;
                                    method.Body.Instructions[i + 1].OpCode = OpCodes.Nop;
                                    LINE++;
                                }
                                catch (Exception ex) { }
                            }
                            ///////////////////////////////
                            if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].Operand.ToString() == "System.String <Module>::smethod_6<System.String>(System.UInt32)")
                            {
                                try
                                {
                                    uint end = (uint)method.Body.Instructions[i].GetLdcI4Value();
                                    string DecryptString = STRING_DECODE.smethod_<string>(end, smethod_6_Left_num, smethod_6_Right_num);
                                    method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                                    method.Body.Instructions[i].Operand = DecryptString;
                                    method.Body.Instructions[i + 1].OpCode = OpCodes.Nop;
                                    LINE++;
                                }
                                catch (Exception ex) { }
                            }
                        }
                        }
                        catch (Exception ex) { }
                    }
            }
            ModuleWriterOptions writerOptions = new ModuleWriterOptions(module);
            writerOptions.MetaDataOptions.Flags |= MetaDataFlags.PreserveAll;
            writerOptions.Logger = DummyLogger.NoThrowInstance;

            module.Write(args[0]+ "Cleaned.exe", writerOptions);
            Console.WriteLine(STR + LINE.ToString());
            Console.WriteLine("Press Any Key......");
            Console.ReadKey();
        }
        public static string getArrayName(ModuleDefMD module)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Dup && method.Body.Instructions[i+1].OpCode == OpCodes.Ldtoken && method.Body.Instructions[i+2].OpCode == OpCodes.Call && method.Body.Instructions[i+3].OpCode == OpCodes.Stloc_1)
                        {
                            Array_Name = method.Body.Instructions[i + 1].Operand.ToString();
                        }
                    }
                }
            }
            return null;
        }
        public static uint[] getArray(ModuleDefMD module, string fieldName)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (FieldDef fields in type.Fields)
                {
                    if (!fieldName.ToLower().Contains(fields.Name.ToLower())) continue;
                    if (!fields.HasFieldRVA) continue;
                    if (!(fields.InitialValue.Length != 0)) continue;
                    if (!fields.FullName.ToLower().Contains("module")) continue;
                    if (!fields.IsStatic) continue;
                    if (!fields.IsAssembly) continue;
                    byte[] arrrr = fields.InitialValue;
                    uint[] decoded = new uint[arrrr.Length / 4];
                    Buffer.BlockCopy(arrrr, 0, decoded, 0, arrrr.Length);
                    arrayy = (uint[])decoded;
                }
            }
            return null;
        }

        public static string unit_num(ModuleDefMD module)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4_S && method.Body.Instructions[i + 1].OpCode == OpCodes.Stloc_0 )
                        {
                            num = (uint)method.Body.Instructions[i].GetLdcI4Value();
                        }
                    }
                }
            }
            return null;
        }

        public static string unit_num2(ModuleDefMD module)
        {
            foreach (TypeDef type in module.Types)
            {
                foreach (MethodDef method in type.Methods)
                {
                    if (!method.HasBody) continue;
                    for (int i = 0; i < method.Body.Instructions.Count; i++)
                    {
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldc_I4 && method.Body.Instructions[i + 1].OpCode == OpCodes.Stloc_3)
                        {
                            num2 = (uint)method.Body.Instructions[i].GetLdcI4Value();
                        }
                    }
                }
            }
            return null;
        }




    }
}
