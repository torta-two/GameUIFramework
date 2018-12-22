using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DictionaryExtension
{
    /// <summary>
    /// 扩展字典类中的TryGetValue方法
    /// 可以直接通过给出key返回value,而不是像原方法一样返回bool值
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="dict"></param>
    /// <param name="key"></param>
    /// <returns></returns>

    public static TValue TryGetValue<TKey,TValue>(this Dictionary<TKey,TValue> dict,TKey key)
    {
        TValue value;
        dict.TryGetValue(key, out value);

        return value;
    }
}
