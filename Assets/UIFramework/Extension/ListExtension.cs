using System.Collections.Generic;

public static class ListExtension
{
    /// <summary>
    /// 扩展List类
    /// 查找字段是指定UIPanelType的UIPanel,返回UIPanel的引用
    /// </summary>
    /// <param name="list">UIPanel的List</param>
    /// <param name="type"></param>
    /// <returns></returns>
    /// 
    public static UIPanel SearchPanelForType(this List<UIPanel> list,UIPanelType type)
    {
        foreach (var item in list)
        {
            if (item.UIPanelType == type)
                return item;
        }

        return null;
    }
}
