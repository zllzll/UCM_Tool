using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace UCM_Tools.Tools
{
    public class EnumCls
    {
        /// <summary>
        /// 由枚举名称获取属性描述
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        public static string GetEnumDescription<T>(T enumValue)
        {
            try
            {
                string value = enumValue.ToString();
                FieldInfo field = enumValue.GetType().GetField(value);
                object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);    //获取描述属性
                if (objs == null || objs.Length == 0)    //当描述属性没有时，直接返回名称
                {
                    return value;
                }

                DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
                return descriptionAttribute.Description;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 枚举 int 转 枚举名称
        /// </summary>
        /// <typeparam name="T">枚举</typeparam>
        /// <param name="itemValue">int值</param>
        /// <returns></returns>
        public static T ConvertEnumToString<T>(int itemValue)
        {
            return (T)Enum.Parse(typeof(T), itemValue.ToString());
        }

        /// <summary>
         /// 根据属性描述获取枚举值
         /// </summary>
         /// <typeparam name="T">类型</typeparam>
         /// <param name="des">属性说明</param>
         /// <returns>枚举值</returns>
        public static T GetEnum<T>(string des) where T : struct, IConvertible
        {
            Type type = typeof(T);
            if (!type.IsEnum)
            {
                    return default(T);
            }
            T[] enums = (T[])Enum.GetValues(type);
            T temp;
            if (!Enum.TryParse(des, out temp))
            {
                    temp = default(T);
            }
            for (int i = 0; i < enums.Length; i++)
            {
                    string name = enums[i].ToString();
                    FieldInfo field = type.GetField(name);
                    object[] objs = field.GetCustomAttributes(typeof(DescriptionAttribute), false);
                    if (objs == null || objs.Length == 0)
                    {
                            continue;
                    }
                    DescriptionAttribute descriptionAttribute = (DescriptionAttribute)objs[0];
                    string edes = descriptionAttribute.Description;
                    if (des == edes)
                    {
                            temp = enums[i];
                            break;
                    }
            }
 
            return temp;
        }

        /// <summary>
        /// 枚举名称转int
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="itemValue"></param>
        /// <returns></returns>
        public static int EnumToInt<T>(T itemValue)
        {
            return Convert.ToInt32(itemValue);
        }

         public static void EnumDescriptionToComboBox<T>(ComboBox cmb)
         {
             cmb.Items.Clear();
             foreach (T t in Enum.GetValues(typeof(T)))
             {
                 cmb.Items.Add(EnumCls.GetEnumDescription(t));
             }
         }

        public static void EnumDescriptionToComboBox<T>(UIComboBox cmb)
        {
            cmb.Items.Clear();
            foreach (T t in Enum.GetValues(typeof(T)))
            {
                cmb.Items.Add(EnumCls.GetEnumDescription(t));
            }
        }

    }
}
