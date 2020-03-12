using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExc2
{
    public class Teachter
    {
        #region --声明教师类成员变量
        public string _name;
        public int _age;
        public string _dw;
        public string _zc;
        public double _gz;
        #endregion


        #region --声明类的方法--
        /// <summary>
        /// 调整工资
        /// </summary>
        /// <param name="addgz">增加的额度</param>
        /// <returns>返回调整后的工资额度</returns>
        public double Tzgz(double addgz)
        {
            _gz += addgz;
            return _gz;
        }

        public string ZhiCheng(string newzc)
        {
            string str="";
            str = _name + "当前职称是：" + _zc + ",调整为：" + newzc;
            return str;
        }
        #endregion

    }
}
