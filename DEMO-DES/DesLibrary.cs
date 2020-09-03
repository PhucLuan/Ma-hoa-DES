using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoaDES
{
    public static class DesLibrary
    {
        #region Mảng tiêu Chuẩn
        //PC1
        static int[] pc1 = new int[] { 57, 49, 41, 33, 25, 17, 9, 1, 58, 50, 42, 34, 26, 18, 10, 2, 59, 51, 43, 35, 27, 19, 11, 3, 60, 52, 44, 36, 63, 55, 47, 39, 31, 23, 15, 7, 62, 54,
                46, 38, 30, 22, 14, 6, 61, 53, 45, 37, 29, 21, 13, 5, 28, 20, 12, 4 };
        //PC2
        static int[] pc2 = new int[] { 14, 17, 11, 24, 1, 5, 3, 28, 15, 6, 21, 10, 23, 19, 12, 4, 26, 8, 16, 7, 27, 20, 13, 2, 41, 52, 31, 37, 47, 55, 30, 40, 51, 45, 33,
                48, 44, 49, 39, 56, 34, 53, 46, 42, 50, 36, 29, 32 };
        //Mở rộng E
        static int[] E = new int[] { 32, 1, 2, 3, 4, 5, 4, 5, 6, 7, 8, 9, 8, 9, 10, 11, 12, 13, 12, 13, 14,
                15, 16, 17, 16, 17, 18, 19, 20, 21, 20, 21, 22, 23, 24, 25, 24, 25, 26, 27, 28, 29, 28, 29, 30, 31, 32, 1 };

        //Hoán vị P
        static int[] P = new int[] { 16, 7, 20, 21, 29, 12, 28, 17, 1, 15, 23, 26, 5, 18, 31, 10, 2, 8, 24, 14, 32, 27, 3, 9, 19, 13, 30, 6, 22, 11, 4, 25 };

        static int[] IP = new int[] { 58, 50, 42, 34, 26, 18, 10, 2, 60, 52, 44, 36, 28, 20, 12, 4, 62, 54, 46,
                38, 30, 22, 14, 6, 64, 56, 48, 40, 32, 24, 16, 8, 57, 49, 41, 33, 25, 17, 9, 1,
                59, 51, 43, 35, 27, 19, 11, 3, 61, 53, 45, 37, 29, 21, 13, 5, 63, 55, 47, 39, 31, 23, 15, 7 };
        static int[] IP1 = new int[] { 40, 8, 48, 16, 56, 24, 64, 32, 39, 7, 47, 15, 55, 23, 63, 31, 38, 6,
                46, 14, 54, 22, 62, 30, 37, 5, 45, 13, 53, 21, 61, 29, 36, 4, 44, 12, 52, 20, 60, 28, 35, 3,
                43, 11, 51, 19, 59, 27, 34, 2, 42, 10, 50, 18, 58, 26, 33, 1, 41, 9, 49, 17, 57, 25 };
        #endregion

        public static string[] ListKL = new string[17];
        public static string[] ListKR = new string[17];
        //Mã hóa
        public static string EncrpytionDES(string K, string _M)
        {
            string C = "";


            string M = cvtHextToBina(_M);
            string IPM = transposition(M, IP); //Chuyển vị IP
            string L0 = IPM.Substring(0, 32);
            string R0 = IPM.Substring(32, 32);
            string tmtL = L0;
            string tmtR = R0;
            string L = "";
            string R = "";

            Array.Clear(ListKL, 0, ListKL.Length);
            Array.Clear(ListKR, 0, ListKL.Length);
            ListKL[0] = cvtBinaToHex(tmtL);
            ListKR[0] = cvtBinaToHex(tmtR);

            string[] ListKey = ListKeys(K);
            for (int i = 0; i < 16; i++)
            {
                
                L = tmtR;//L = R tmt
                string E_R0 = transposition(tmtR, E);//Mở rộng nữa phải
                                                     //XOR Khóa
                                                     //ListKey(K);
                string K1 = ListKey[i];
                string A = XORBIT(E_R0, K1);
                //Thế S-BOX
                string SB = SBOX(A);
                //Hoán vị P(B)

                string PB = transposition(cvtHextToBina(SB), P);
                //R1=P(B) xor L0
                R = XORBIT(PB, tmtL);
                
                tmtL = L;
                tmtR = R;
                ListKL[i + 1] = cvtBinaToHex(L);
                ListKR[i + 1] = cvtBinaToHex(R);

            }
            C = cvtBinaToHex(transposition(R + L, IP1));
            return C;
        }

        //Giải mã
        public static string DecrpytionDES(string K, string _M)
        {
            
            string C = "";
            string M = cvtHextToBina(_M);
            string IPM = transposition(M, IP); //Chuyển vị IP
            string L0 = IPM.Substring(0, 32);
            string R0 = IPM.Substring(32, 32);
            string tmtL = L0;
            string tmtR = R0;
            string L = "";
            string R = "";
            Array.Clear(ListKL, 0, ListKL.Length);
            Array.Clear(ListKR, 0, ListKL.Length);
            ListKL[0] = cvtBinaToHex(tmtL);
            ListKR[0] = cvtBinaToHex(tmtR);

            string[] ListKey = ListKeys(K);
            for (int i = 15; i >= 0; i--)
            {
                L = tmtR;//L = R tmt
                string E_R0 = transposition(tmtR, E);//Mở rộng nữa phải
                                                     //XOR Khóa
                                                     //ListKey(K);
                string K1 = ListKey[i];
                string A = XORBIT(E_R0, K1);
                //Thế S-BOX
                string SB = SBOX(A);
                //Hoán vị P(B)

                string PB = transposition(cvtHextToBina(SB), P);
                //R1=P(B) xor L0
                R = XORBIT(PB, tmtL);
                
                tmtL = L;
                tmtR = R;

                ListKL[i + 1] = cvtBinaToHex(L);
                ListKR[i + 1] = cvtBinaToHex(R);
            }
            C = cvtBinaToHex(transposition(R + L, IP1));
            return C;
        }
        //Chuyển Hex sang Nhị phân
        static string cvtHextToBina(string hexstring)
        {
            string binarystring = String.Join(String.Empty,
            hexstring.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            return binarystring;
        }
        //Chuyển nhị phân sang Hex
        public static string cvtBinaToHex(string strBinary)
        {
            string strHex = Convert.ToInt64(strBinary, 2).ToString("X");
            return strHex;
        }
        //Chuyển vị --ghép bit
        static string transposition(string Key, int[] _PC1)
        {
            string result = "";
            foreach (var item in _PC1)
            {
                result += Key.Substring(item - 1, 1);
            }

            return result;
        }
        //Dịch vòng trái
        static string RotleftShift(string _string, int Si)
        {

            char[] Rotlef = _string.ToArray();
            string result = "";
            char First = Rotlef[0];

            if (Si == 1)
            {
                for (int i = 0; i < Rotlef.Length; i++)
                {
                    try
                    {
                        Rotlef[i] = Rotlef[i + 1];
                        result += Rotlef[i];
                    }
                    catch (Exception)
                    {
                        Rotlef[i] = First;
                        result += Rotlef[i];
                    }

                }
                return result;
                //return result;
            }
            else
            {
                char Secound = Rotlef[1];
                for (int i = 0; i < Rotlef.Length - 1; i++)
                {
                    try
                    {
                        Rotlef[i] = Rotlef[i + 2];
                        result += Rotlef[i];
                    }
                    catch (Exception)
                    {
                        Rotlef[i] = First;
                        Rotlef[i + 1] = Secound;
                        result += Rotlef[i];
                        result += Rotlef[i + 1];
                    }

                }
                //return cvtBinaToHex(result);
                return result;
            }
        }
        //Tạo 16 khóa
        static string[] GenKey(string KL, string KR)
        {
            string C1;
            string D1;
            string[] result = new string[16];
            int[] s = new int[] { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

            for (int i = 0; i < 16; i++)
            {
                C1 = RotleftShift(KL, s[i]);
                D1 = RotleftShift(KR, s[i]);
                //result[i] = C1 + D1;
                KL = C1;
                KR = D1;
                C1 = "";
                D1 = "";
                result[i] = KL + KR;
            }
            return result;
        }

        public static string[] ListKeys(string K)
        {

            string PC1K = transposition(cvtHextToBina(K), pc1);
            List<string> ListKey = new List<string>();
            foreach (var item in GenKey(PC1K.Substring(0, 28), PC1K.Substring(28, 28)))
            {
                ListKey.Add(transposition(item, pc2));
            }
            return ListKey.ToArray();
        }

        static string XORBIT(string _A, string _B)
        {

            string result = "";
            char[] ArrayA = _A.ToArray();
            char[] ArrayB = _B.ToArray();

            //Console.WriteLine();
            if (ArrayA.Count() == 48)
            {
                for (int i = 0; i < 48; i++)
                {

                    if (ArrayA[i] == ArrayB[i])
                    {
                        result += "0";
                    }
                    else
                        result += "1";
                }
                return result;
            }
            else
            {
                for (int i = 0; i < 32; i++)
                {

                    if (ArrayA[i] == ArrayB[i])
                    {
                        result += "0";
                    }
                    else
                        result += "1";
                }
                return result;
            }
        }

        static string SBOX(string A)
        {

            int[] S1 = new int[] { 14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7, 0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8, 4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0, 15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13 };
            int[] S2 = new int[] { 15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10, 3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5, 0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15, 13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9 };
            int[] S3 = new int[] { 10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8, 13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1, 13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7, 1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12 };
            int[] S4 = new int[] { 7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15, 13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9, 10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4, 3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14 };
            int[] S5 = new int[] { 2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9, 14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6, 4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14, 11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3 };
            int[] S6 = new int[] { 12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11, 10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8, 9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6, 4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13 };
            int[] S7 = new int[] { 4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1, 13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6, 1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2, 6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12 };
            int[] S8 = new int[] { 13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7, 1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2, 7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8, 2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11 };
            string[] ArrayStr = new string[8];
            for (int i = 0; i < 8; i++)
            {
                ArrayStr[i] = A.Substring(i * 6, 6);
            }

            //Thế S-BOX

            string Result = "";
            for (int i = 0; i < 8; i++)
            {

                int col = Convert.ToInt32(ArrayStr[i].Substring(1, 4), 2);
                int row = Convert.ToInt32((ArrayStr[i].Substring(0, 1) + ArrayStr[i].Substring(5, 1)), 2);
                int indext = row * 16 + col;
                switch (i)
                {
                    case 0:
                        Result += S1[indext].ToString("X");
                        break;
                    case 1:
                        Result += S2[indext].ToString("X");
                        break;
                    case 2:
                        Result += S3[indext].ToString("X");
                        break;
                    case 3:
                        Result += S4[indext].ToString("X");
                        break;
                    case 4:
                        Result += S5[indext].ToString("X");
                        break;
                    case 5:
                        Result += S6[indext].ToString("X");
                        break;
                    case 6:
                        Result += S7[indext].ToString("X");
                        break;
                    case 7:
                        Result += S8[indext].ToString("X");
                        break;
                }

            }

            return Result;
        }
    }
}
