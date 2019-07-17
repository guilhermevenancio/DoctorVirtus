using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DoctorVirtus.Aplicativo.Utils {
  
    public static class Parse {

        public static object IsEmpty(string value) {
            try {
                if (value.Trim() == "")
                    return DBNull.Value;
                else
                    return value.Trim();
            } catch {
                return DBNull.Value;
            }
        }

        public static object IsEmpty(object value) {
            try {
                if (Convert.ToString(value).Trim() == "")
                    return DBNull.Value;
                else
                    return value;
            } catch {
                return DBNull.Value;
            }
        }

        /* TODO ERROR: Skipped WarningDirectiveTrivia */
        public static string ToString(object value) {
            /* TODO ERROR: Skipped WarningDirectiveTrivia */
            try {
                if (Convert.IsDBNull(value))
                    return null;
                else
                    return Convert.ToString(value).Trim();
            } catch {
                return null;
            }
        }

        public static int? ToInt(object value) {

            try {
                if (!IsNumeric(value))
                    return null;
                else
                    return Convert.ToInt32(value);
            } catch {
                return 0;
            }
        }

        public static bool ToBoolean(object value) {
            try {
                if (Convert.IsDBNull(value))
                    return false;
                else
                    return Convert.ToBoolean(value);
            } catch {
                return false;
            }
        }

        public static decimal ToDecimal(object value, int CasasDecimais = 2) {
            try {
                if (!IsNumeric(value))
                    return 0;
                else
                    return Math.Round(Convert.ToDecimal(value), CasasDecimais);// String.Format("{0:N" & CasasDecimais & "}", Convert.ToDecimal(Value))
            } catch {
                return 0;
            }
        }

        public static byte[] ToByte(object value) {
            try {
                if (Convert.IsDBNull(value))
                    return null;
                else
                    return ObjectToByteArray(value); // Value;
            } catch {
                return null;
            }
        }

        public static byte[] ObjectToByteArray(object obj) {

            if (obj == null) return null;

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream()) {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public static bool IsNumeric(object Expression) {
            
            if (Expression == null || Expression is DateTime) return false;
            
            if (Expression is short || Expression is int || Expression is long || Expression is decimal || Expression is float || Expression is double) return true;
            
            try {

                if (Expression is string)
                    double.Parse(Expression as string);
                else
                    double.Parse(Expression.ToString());
                return true;
            } catch {
                return false;
            }
        }
    }
}