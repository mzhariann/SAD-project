using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SAD
{
    public static class TemplatePopulater
    {
        
        public static void populate(int id , string table, TemplateFile temp) {
            string[] columns = dbConnection.getTableColumns(table);
            string tempText = temp.getText();

            foreach (string col in columns)
            {
                string pattern = "<@" + table + "." + col + ">";
                string replacement = dbConnection.getField(table , id , col);
                Regex rgx = new Regex(pattern);
                tempText = rgx.Replace(tempText, replacement);
            }
            temp.setText(tempText);
        }


    }
}
