using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAD
{
    public class TemplateFile
    {
        string _fileName;
        string _text;
        TemplateFile(string fileName) {
            _fileName = fileName;
            _text = null;
        }
        public string getText() {
            if(_text == null)
                _text = System.IO.File.ReadAllText(@_fileName);
            return _text;
        }
        public void setText(string t) {
            _text = t;
        }
    }
}
