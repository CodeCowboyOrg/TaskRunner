using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Reflection;

namespace TaskRunner.Util
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    public class ListViewUtil : IComparer
    {
        #region Private Members
        private int m_activeColumn = 0;
        #endregion Private Members

        #region Constructor and Destructors
        public ListViewUtil()
        {

        }
        #endregion Constructor and Destructors

        #region Static Methods


        public static void Sort(ListView lv, int iColumn)
        {
            ListViewUtil lvu = new ListViewUtil();
            lvu.ActiveColumn = iColumn;
            lv.ListViewItemSorter = lvu;
            lv.Sort();
            lv.ListViewItemSorter = null;
            lvu = null;
        }


        public static void AddListViewItem(ListView lv, int insertAt, params string[] items)
        {
            ListViewItem li = new ListViewItem();
            if (items.Length > 0)
            {
                li.Text = items[0];
            }
            for (int i = 1; i < items.Length; i++)
            {
                li.SubItems.Add(items[i]);
            }
            lv.Items.Insert(insertAt, li);
        }

        public static void UpdateListViewItem(ListView lv, int index, params string[] items)
        {
            ListViewItem li = lv.Items[index];
            if (li == null) return;
            if (items.Length > 0)
            {
                for (int i = 0; i < items.Length; i++)
                {
                    li.SubItems[i].Text = items[i];
                }
            }
        }

        public static void UpdateListViewItem(ListView lv, object tag, params string[] items)
        {
            foreach (ListViewItem li in lv.Items)
            {
                if (li.Tag == tag && items.Length > 0)
                {
                    for (int i = 0; i < items.Length; i++)
                    {
                        li.SubItems[i].Text = items[i];
                    }
                    return;
                }
            }
        }


        public static void AddListViewItem(ListView lv, object tag, params string[] items)
        {
            ListViewItem li = new ListViewItem();
            li.Tag = tag;
            if (items.Length > 0)
            {
                li.Text = items[0];
            }
            for (int i = 1; i < items.Length; i++)
            {
                li.SubItems.Add(items[i]);
            }
            lv.Items.Add(li);
        }


        public static void AddListViewItem(ListView lv, int insertAt, object tag, params string[] items)
        {
            ListViewItem li = new ListViewItem();
            li.Tag = tag;
            if (items.Length > 0)
            {
                li.Text = items[0];
            }
            for (int i = 1; i < items.Length; i++)
            {
                li.SubItems.Add(items[i]);
            }
            lv.Items.Insert(insertAt, li);
        }



        public static void UnSelectAll(ListView lv)
        {
            foreach (ListViewItem li in lv.SelectedItems)
            {
                li.Selected = false;
            }
        }

        #endregion Static Methods

        #region Public Properties
        public int ActiveColumn
        {
            get { return m_activeColumn; }
            set { m_activeColumn = value; }
        }
        #endregion Public Properties
        
        #region Interface IComparer
        public int Compare(object x, object y)
        {
            ListViewItem rowA = (ListViewItem)x;
            ListViewItem rowB = (ListViewItem)y;
            return String.Compare(rowA.SubItems[m_activeColumn].Text, rowB.SubItems[m_activeColumn].Text);
        }
        #endregion Interface IComparer
    }
}
