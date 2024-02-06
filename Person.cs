using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EditPerson
{
    [Serializable,
        XmlRoot (Namespace ="http://www.MyCompany.com")]
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [NonSerialized]
        int age;
        public int Age { get; set; }
        public override string ToString()
        {
            return LastName + " " + FirstName + "\nВозраст: " + Age + "\n";
        }
    }
}
