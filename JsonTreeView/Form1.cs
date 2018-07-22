using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JsonTreeview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView_json.Nodes.Clear();
            TreeNode node = null;
            JObject jObject = JObject.Parse(textBox_json.Text); //添加异常处理
            if (jObject.GetType() == typeof(Newtonsoft.Json.Linq.JObject))
            {
                node = treeView_json.Nodes.Add("[Object]");
            }
            else if (jObject.GetType() == typeof(Newtonsoft.Json.Linq.JArray))
            {
                node = treeView_json.Nodes.Add("[Array]");
            }
            foreach (var obj in jObject)
            {
                showJsonTree(treeView_json, jObject, obj.Key.ToString(), null, node);
            }
        }

        private void showJsonTree(TreeView tree, JObject jObject, String key, string title = null, TreeNode node = null)
        {
            string text = "";
            TreeNode index;
            if (jObject[key].GetType() == typeof(Newtonsoft.Json.Linq.JArray))
            {
                text = key + ":[Array]";
            }
            else if (jObject[key].GetType() == typeof(Newtonsoft.Json.Linq.JObject))
            {
                text = key + ":[Object]";
            }
            else if (jObject[key].GetType() == typeof(Newtonsoft.Json.Linq.JValue))
            {
                if ((string)jObject[key] == null)
                {
                    text = key + ":" + "null";
                }
                else { text = key + ":" + (string)jObject[key]; }
            }
            if (title != null)
            {
                text = title + ":" + text;
            }
            index = node.Nodes.Add(text);
            if (jObject[key].GetType() == typeof(Newtonsoft.Json.Linq.JObject))
            {
                JObject @object = JObject.Parse(jObject[key].ToString());
                foreach (var obj in @object)
                {
                    showJsonTree(tree, @object, obj.Key, null, index);
                }
            }
            else if (jObject[key].GetType() == typeof(Newtonsoft.Json.Linq.JArray))
            {
                JArray jArray = JArray.Parse(jObject[key].ToString());
                int inx = -1;
                foreach (var obj in jArray)
                {
                    inx++;
                    node = index.Nodes.Add("[" + inx + "]");
                    if (obj.GetType() == typeof(Newtonsoft.Json.Linq.JObject))
                    {
                        JObject @object = JObject.Parse(obj.ToString());
                        foreach (var ob in @object)
                        {
                            showJsonTree(tree, @object, ob.Key, null, node);
                        }
                    }
                    else if (obj.GetType() == typeof(Newtonsoft.Json.Linq.JValue))
                    {
                        if (obj.ToString() == null)
                        {
                            node.Nodes.Add("null");
                        }
                        else { node.Nodes.Add(obj.ToString()); }
                    }
                }
            }
        }
    }
}
