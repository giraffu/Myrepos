using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyRepos
{
    public class HandleObject
    {
        /// <summary>
        /// 得到一个对象的属性值
        /// </summary>
        /// <param name="obj">对象</param>
        /// <param name="name">属性名称</param>
        /// <returns>属性值</returns>
        public object GetPropertyValue(object obj, string name)
        {
            Type type = obj.GetType();
            PropertyInfo item = type.GetProperty(name);

            object x = item.GetValue(obj);
            return x;
        }
    }
}
