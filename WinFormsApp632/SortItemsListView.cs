using System;
using System.Collections;
using System.Windows.Forms;

public class ListViewColumnSorter : IComparer
{
    private int ColumnToSort;
    private SortOrder OrderOfSort;
    private CaseInsensitiveComparer ObjectCompare;

    public ListViewColumnSorter()
    {
        ColumnToSort = 0;
        OrderOfSort = SortOrder.None;
        ObjectCompare = new CaseInsensitiveComparer();
    }

    public int Compare(object x, object y)
    {
        ListViewItem listviewX = (ListViewItem)x;
        ListViewItem listviewY = (ListViewItem)y;

        if (IsSpecialItem(listviewX) || IsSpecialItem(listviewY))
        {
            return 0;
        }

        if (ColumnToSort == 1)
        {
            DateTime dateX = DateTime.Parse(listviewX.SubItems[ColumnToSort].Text);
            DateTime dateY = DateTime.Parse(listviewY.SubItems[ColumnToSort].Text);

            int compareResult = DateTime.Compare(dateX, dateY);

            return (OrderOfSort == SortOrder.Ascending) ? compareResult : -compareResult;
        }
        else
        {
            int compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);

            return (OrderOfSort == SortOrder.Ascending) ? compareResult : -compareResult;
        }
    }
    public int SortColumn
    {
        set { ColumnToSort = value; }
        get { return ColumnToSort; }
    }

    public SortOrder Order
    {
        set { OrderOfSort = value; }
        get { return OrderOfSort; }
    }

    private bool IsSpecialItem(ListViewItem item)
    {
        return item.Text.StartsWith("<-.........");
    }
}
